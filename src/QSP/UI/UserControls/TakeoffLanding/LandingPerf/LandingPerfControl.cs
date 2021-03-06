﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QSP.AircraftProfiles.Configs;
using QSP.AviationTools;
using QSP.LandingPerfCalculation;
using QSP.LibraryExtension;
using QSP.MathTools;
using QSP.RouteFinding.Airports;
using QSP.UI.ControlStates;
using QSP.UI.Factories;
using QSP.UI.MsgBox;
using QSP.UI.UserControls.TakeoffLanding.Common;
using QSP.UI.UserControls.TakeoffLanding.LandingPerf.FormControllers;

namespace QSP.UI.UserControls.TakeoffLanding.LandingPerf
{
    public partial class LandingPerfControl : UserControl
    {
        public const string FileName = "LandingPerfControl.xml";

        private IFormController controller;
        private LandingPerfElements elements;
        private List<PerfTable> tables;
        private AcConfigManager aircrafts;
        private Func<AircraftRequest> acRequestGetter;

        private PerfTable currentTable;
        private AutoWeatherSetter wxSetter;

        public AirportManager Airports
        {
            get { return airportInfoControl.Airports; }
            set
            {
                airportInfoControl.Airports = value;
                airportInfoControl.RefreshAirportInfo();
            }
        }

        public LandingPerfControl()
        {
            InitializeComponent();
        }

        private void setWeatherBtnHandlers()
        {
            wxSetter = new AutoWeatherSetter(weatherInfoControl, airportInfoControl);
            wxSetter.Subscribe();
        }

        private void InitializeControls()
        {
            appSpdIncTxtBox.Text = "5";
            wtUnitComboBox.SelectedIndex = 0; // KG 
        }

        public void TryLoadState()
        {
            var doc = StateManager.Load(FileName);
            if (doc != null) new ControlState(this).Load(doc);
        }

        public void TrySaveState()
        {
            StateManager.Save(FileName, new ControlState(this).Save());
        }

        private void SaveState(object sender, EventArgs e)
        {
            TrySaveState();
        }

        private void InitializeElements()
        {
            var ap = airportInfoControl;
            var wx = weatherInfoControl;

            elements = new LandingPerfElements(
                ap.airportNameLbl,
                ap.airportTxtBox,
                ap.lengthTxtBox,
                ap.elevationTxtBox,
                ap.rwyHeadingTxtBox,
                wx.windDirTxtBox,
                wx.windSpdTxtBox,
                wx.oatTxtBox,
                wx.pressTxtBox,
                weightTxtBox,
                appSpdIncTxtBox,
                ap.rwyComboBox,
                ap.lengthUnitComboBox,
                ap.slopeComboBox,
                wx.tempUnitComboBox,
                brakeComboBox,
                wx.surfCondComboBox,
                wx.pressUnitComboBox,
                wtUnitComboBox,
                flapsComboBox,
                revThrustComboBox,
                resultsRichTxtBox);
        }

        public void Init(
            AcConfigManager aircrafts,
            List<PerfTable> tables,
            AirportManager airports,
            Func<AircraftRequest> acRequestGetter)
        {
            airportInfoControl.Init();

            // Create the reference to the UI controls.
            InitializeElements();

            // Set default values for the controls.
            InitializeControls();

            setWeatherBtnHandlers();

            requestBtn.SetToolTip("Use aircraft and weights calculated from 'Fuel' page.");

            this.aircrafts = aircrafts;
            this.tables = tables;
            UpdateAircraftList();
            this.Airports = airports;
            this.acRequestGetter = acRequestGetter;
        }

        private string[] AvailAircraftTypes()
        {
            var allProfileNames = tables.Select(t => t.Entry.ProfileName)
                .ToHashSet();

            return aircrafts
                .Aircrafts
                .Where(c => allProfileNames.Contains(c.Config.LdgProfile))
                .Select(c => c.Config.AC)
                .Distinct()
                .OrderBy(i => i)
                .ToArray();
        }

        private bool LandingProfileExists(string profileName)
        {
            return tables.Any(c => c.Entry.ProfileName == profileName);
        }

        private void UpdateAircraftList()
        {
            var items = acListComboBox.Items;

            items.Clear();
            items.AddRange(AvailAircraftTypes());

            if (items.Count > 0) acListComboBox.SelectedIndex = 0;
        }

        private void RefreshRegistrations(object sender, EventArgs e)
        {
            if (acListComboBox.SelectedIndex >= 0)
            {
                var ac = aircrafts.FindAircraft(acListComboBox.Text);
                var items = regComboBox.Items;
                items.Clear();

                items.AddRange(ac
                    .Where(c => LandingProfileExists(c.Config.LdgProfile))
                    .Select(c => c.Config.Registration)
                    .ToArray());

                if (items.Count > 0) regComboBox.SelectedIndex = 0;
            }
        }

        private void RequestBtnClick(object sender, EventArgs e)
        {
            var ac = acRequestGetter();

            if (ac == null ||
                aircrafts.Find(ac.Registration) == null ||
                aircrafts.Find(ac.Registration).Config.AC != ac.Aircraft)
            {
                this.ShowWarning(
                "The aircraft selected in fuel planning page does not " +
                "have a corresponding landing performance profile.");
                return;
            }

            using (var frm = new CustomFuelForm())
            {
                frm.Init(ac);
                frm.ShowInTaskbar = false;
                frm.StartPosition = FormStartPosition.Manual;
                var pt = requestBtn.PointToScreen(Point.Empty);
                frm.Location = new Point(pt.X - 150, pt.Y + 50);
                frm.WeightSet += (_s, _e) =>
                {
                    acListComboBox.Text = ac.Aircraft;
                    regComboBox.Text = ac.Registration;
                    weightTxtBox.Text = Numbers.RoundToInt(frm.LandingWtKg).ToString();
                    wtUnitComboBox.SelectedIndex = (int)ac.WtUnit;
                };

                frm.ShowDialog();
            }
        }

        private void RegistrationChanged(object sender, EventArgs e)
        {
            if (regComboBox.SelectedIndex < 0)
            {
                RefreshWtColor();
                return;
            }

            // unsubsribe all event handlers
            if (controller != null)
            {
                UnSubscribe(controller);
                currentTable = null;
                controller = null;
            }

            // set currentTable and controller
            if (tables != null && tables.Count > 0)
            {
                var ac = aircrafts.Find(regComboBox.Text).Config;
                var profileName = ac.LdgProfile;

                currentTable = tables.First(t => t.Entry.ProfileName == profileName);

                controller = FormControllerFactory.GetController(
                    ControllerType.Boeing, ac, currentTable, elements, this);
                // TODO: not completely right

                Subscribe(controller);
                controller.Initialize();
                RefreshWtColor();
            }
        }

        private void Subscribe(IFormController controller)
        {
            var c = controller;
            var w = weatherInfoControl;

            w.surfCondComboBox.SelectedIndexChanged += c.SurfCondChanged;
            wtUnitComboBox.SelectedIndexChanged += c.WeightUnitChanged;
            flapsComboBox.SelectedIndexChanged += c.FlapsChanged;
            revThrustComboBox.SelectedIndexChanged += c.ReverserChanged;
            brakeComboBox.SelectedIndexChanged += c.BrakesChanged;
            calculateBtn.Click += c.Compute;

            c.CalculationCompleted += SaveState;
        }

        private void UnSubscribe(IFormController controller)
        {
            var c = controller;
            var w = weatherInfoControl;

            w.surfCondComboBox.SelectedIndexChanged -= c.SurfCondChanged;
            wtUnitComboBox.SelectedIndexChanged -= c.WeightUnitChanged;
            flapsComboBox.SelectedIndexChanged -= c.FlapsChanged;
            revThrustComboBox.SelectedIndexChanged -= c.ReverserChanged;
            brakeComboBox.SelectedIndexChanged -= c.BrakesChanged;
            calculateBtn.Click -= c.Compute;

            c.CalculationCompleted -= SaveState;
        }

        private void RefreshWtColor()
        {
            var ac = aircrafts?.Find(regComboBox.Text);
            var config = ac?.Config;

            if (config != null && double.TryParse(weightTxtBox.Text, out var wtKg))
            {
                if (wtUnitComboBox.SelectedIndex == 1)
                {
                    wtKg *= Constants.LbKgRatio;
                }

                if (wtKg > config.MaxLdgWtKg || wtKg < config.OewKg)
                {
                    weightTxtBox.ForeColor = Color.Red;
                }
                else
                {
                    weightTxtBox.ForeColor = Color.Green;
                }
            }
            else
            {
                weightTxtBox.ForeColor = Color.Black;
            }
        }

        private void WeightTxtBoxChanged(object sender, EventArgs e)
        {
            RefreshWtColor();
        }

        /// <summary>
        /// Refresh the aircraft and registration comboBoxes,
        /// after the AcConfigManager is updated.
        /// </summary>
        public void RefreshAircrafts(object sender, EventArgs e)
        {
            // Set the selected aircraft/registration.
            string ac = acListComboBox.Text;
            string reg = regComboBox.Text;

            UpdateAircraftList();
            acListComboBox.Text = ac;
            regComboBox.Text = reg;

            // Set the color of weight.
            WeightTxtBoxChanged(this, EventArgs.Empty);
        }

        private void TxtRichTextBoxContentsResized(object sender, ContentsResizedEventArgs e)
        {
            resultsRichTxtBox.Height = e.NewRectangle.Height + 10;
        }
    }
}
