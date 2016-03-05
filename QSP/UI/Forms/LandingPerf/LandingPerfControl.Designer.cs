﻿namespace QSP.UI.Forms.LandingPerf
{
    partial class LandingPerfControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox13 = new System.Windows.Forms.GroupBox();
            this.airportInfoControl = new QSP.UI.AirportInfo.AirportInfoControl();
            this.GroupBox14 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.brakeComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.revThrustComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.wtUnitComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.flapsComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.acListComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.requestBtn = new System.Windows.Forms.Button();
            this.Label97 = new System.Windows.Forms.Label();
            this.Label96 = new System.Windows.Forms.Label();
            this.Label102 = new System.Windows.Forms.Label();
            this.appSpdIncTxtBox = new System.Windows.Forms.TextBox();
            this.Label101 = new System.Windows.Forms.Label();
            this.Label100 = new System.Windows.Forms.Label();
            this.Label99 = new System.Windows.Forms.Label();
            this.Label98 = new System.Windows.Forms.Label();
            this.weightTxtBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.GroupBox15 = new System.Windows.Forms.GroupBox();
            this.weatherInfoControl = new QSP.UI.Forms.WeatherInfoControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.surfCondComboBox = new QSP.UI.Controls.ComboBoxWithBorder();
            this.Label105 = new System.Windows.Forms.Label();
            this.GroupBox16 = new System.Windows.Forms.GroupBox();
            this.resultsRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.GroupBox13.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox13
            // 
            this.GroupBox13.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox13.Controls.Add(this.airportInfoControl);
            this.GroupBox13.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox13.Location = new System.Drawing.Point(42, 23);
            this.GroupBox13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox13.Size = new System.Drawing.Size(531, 272);
            this.GroupBox13.TabIndex = 27;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "Runway";
            // 
            // airportInfoControl
            // 
            this.airportInfoControl.Airports = null;
            this.airportInfoControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.airportInfoControl.Location = new System.Drawing.Point(7, 23);
            this.airportInfoControl.Name = "airportInfoControl";
            this.airportInfoControl.Size = new System.Drawing.Size(517, 240);
            this.airportInfoControl.TabIndex = 33;
            // 
            // GroupBox14
            // 
            this.GroupBox14.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox14.Controls.Add(this.tableLayoutPanel7);
            this.GroupBox14.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox14.Location = new System.Drawing.Point(581, 23);
            this.GroupBox14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox14.Size = new System.Drawing.Size(545, 272);
            this.GroupBox14.TabIndex = 11;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "A/C Configuration";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.8764F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.1236F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel7.Controls.Add(this.brakeComboBox, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.revThrustComboBox, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.wtUnitComboBox, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.flapsComboBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.acListComboBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.requestBtn, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.Label97, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.Label96, 2, 5);
            this.tableLayoutPanel7.Controls.Add(this.Label102, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.appSpdIncTxtBox, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.Label101, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.Label100, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.Label99, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.Label98, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.weightTxtBox, 1, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(521, 240);
            this.tableLayoutPanel7.TabIndex = 33;
            // 
            // brakeComboBox
            // 
            this.brakeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brakeComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.brakeComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.brakeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brakeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brakeComboBox.FormattingEnabled = true;
            this.brakeComboBox.Items.AddRange(new object[] {
            "737-600",
            "737-700",
            "737-800",
            "737-900",
            "777-200LR",
            "777F"});
            this.brakeComboBox.Location = new System.Drawing.Point(169, 164);
            this.brakeComboBox.Name = "brakeComboBox";
            this.brakeComboBox.Size = new System.Drawing.Size(151, 31);
            this.brakeComboBox.TabIndex = 45;
            // 
            // revThrustComboBox
            // 
            this.revThrustComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.revThrustComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.revThrustComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.revThrustComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.revThrustComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revThrustComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revThrustComboBox.FormattingEnabled = true;
            this.revThrustComboBox.Items.AddRange(new object[] {
            "737-600",
            "737-700",
            "737-800",
            "737-900",
            "777-200LR",
            "777F"});
            this.revThrustComboBox.Location = new System.Drawing.Point(169, 124);
            this.revThrustComboBox.Name = "revThrustComboBox";
            this.revThrustComboBox.Size = new System.Drawing.Size(151, 31);
            this.revThrustComboBox.TabIndex = 44;
            // 
            // wtUnitComboBox
            // 
            this.wtUnitComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wtUnitComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.wtUnitComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.wtUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wtUnitComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wtUnitComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtUnitComboBox.FormattingEnabled = true;
            this.wtUnitComboBox.Items.AddRange(new object[] {
            "KG",
            "LB"});
            this.wtUnitComboBox.Location = new System.Drawing.Point(354, 44);
            this.wtUnitComboBox.Name = "wtUnitComboBox";
            this.wtUnitComboBox.Size = new System.Drawing.Size(141, 31);
            this.wtUnitComboBox.TabIndex = 43;
            // 
            // flapsComboBox
            // 
            this.flapsComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flapsComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.flapsComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.flapsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flapsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flapsComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flapsComboBox.FormattingEnabled = true;
            this.flapsComboBox.Items.AddRange(new object[] {
            "737-600",
            "737-700",
            "737-800",
            "737-900",
            "777-200LR",
            "777F"});
            this.flapsComboBox.Location = new System.Drawing.Point(169, 84);
            this.flapsComboBox.Name = "flapsComboBox";
            this.flapsComboBox.Size = new System.Drawing.Size(151, 31);
            this.flapsComboBox.TabIndex = 42;
            // 
            // acListComboBox
            // 
            this.acListComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acListComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.acListComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.acListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.acListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acListComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acListComboBox.FormattingEnabled = true;
            this.acListComboBox.Items.AddRange(new object[] {
            "737-600",
            "737-700",
            "737-800",
            "737-900",
            "777-200LR",
            "777F"});
            this.acListComboBox.Location = new System.Drawing.Point(169, 4);
            this.acListComboBox.Name = "acListComboBox";
            this.acListComboBox.Size = new System.Drawing.Size(151, 31);
            this.acListComboBox.TabIndex = 41;
            this.acListComboBox.SelectedIndexChanged += new System.EventHandler(this.acListComboBox_SelectedIndexChanged);
            // 
            // requestBtn
            // 
            this.requestBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.requestBtn.BackColor = System.Drawing.SystemColors.Control;
            this.requestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestBtn.Location = new System.Drawing.Point(354, 4);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(141, 31);
            this.requestBtn.TabIndex = 38;
            this.requestBtn.Text = "Request";
            this.requestBtn.UseVisualStyleBackColor = false;
            this.requestBtn.Visible = false;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // Label97
            // 
            this.Label97.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label97.AutoSize = true;
            this.Label97.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label97.Location = new System.Drawing.Point(4, 8);
            this.Label97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label97.Name = "Label97";
            this.Label97.Size = new System.Drawing.Size(65, 23);
            this.Label97.TabIndex = 36;
            this.Label97.Text = "Aircraft";
            // 
            // Label96
            // 
            this.Label96.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label96.AutoSize = true;
            this.Label96.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label96.Location = new System.Drawing.Point(333, 208);
            this.Label96.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label96.Name = "Label96";
            this.Label96.Size = new System.Drawing.Size(31, 23);
            this.Label96.TabIndex = 37;
            this.Label96.Text = "kts";
            // 
            // Label102
            // 
            this.Label102.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label102.AutoSize = true;
            this.Label102.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label102.Location = new System.Drawing.Point(4, 48);
            this.Label102.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label102.Name = "Label102";
            this.Label102.Size = new System.Drawing.Size(67, 23);
            this.Label102.TabIndex = 8;
            this.Label102.Text = "LDGWT";
            // 
            // appSpdIncTxtBox
            // 
            this.appSpdIncTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appSpdIncTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appSpdIncTxtBox.Location = new System.Drawing.Point(202, 205);
            this.appSpdIncTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appSpdIncTxtBox.Name = "appSpdIncTxtBox";
            this.appSpdIncTxtBox.Size = new System.Drawing.Size(86, 30);
            this.appSpdIncTxtBox.TabIndex = 26;
            // 
            // Label101
            // 
            this.Label101.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label101.AutoSize = true;
            this.Label101.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label101.Location = new System.Drawing.Point(4, 88);
            this.Label101.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label101.Name = "Label101";
            this.Label101.Size = new System.Drawing.Size(48, 23);
            this.Label101.TabIndex = 9;
            this.Label101.Text = "Flaps";
            // 
            // Label100
            // 
            this.Label100.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label100.AutoSize = true;
            this.Label100.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label100.Location = new System.Drawing.Point(4, 128);
            this.Label100.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label100.Name = "Label100";
            this.Label100.Size = new System.Drawing.Size(121, 23);
            this.Label100.TabIndex = 20;
            this.Label100.Text = "Reverse Thrust";
            // 
            // Label99
            // 
            this.Label99.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label99.AutoSize = true;
            this.Label99.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label99.Location = new System.Drawing.Point(4, 168);
            this.Label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label99.Name = "Label99";
            this.Label99.Size = new System.Drawing.Size(67, 23);
            this.Label99.TabIndex = 23;
            this.Label99.Text = "Braking";
            // 
            // Label98
            // 
            this.Label98.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label98.AutoSize = true;
            this.Label98.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label98.Location = new System.Drawing.Point(4, 208);
            this.Label98.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label98.Name = "Label98";
            this.Label98.Size = new System.Drawing.Size(144, 23);
            this.Label98.TabIndex = 24;
            this.Label98.Text = "APP SPD increase";
            // 
            // weightTxtBox
            // 
            this.weightTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightTxtBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxtBox.Location = new System.Drawing.Point(169, 46);
            this.weightTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightTxtBox.Name = "weightTxtBox";
            this.weightTxtBox.Size = new System.Drawing.Size(151, 27);
            this.weightTxtBox.TabIndex = 16;
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.Color.Green;
            this.calculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.ForeColor = System.Drawing.Color.White;
            this.calculateBtn.Location = new System.Drawing.Point(666, 350);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(380, 50);
            this.calculateBtn.TabIndex = 28;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = false;
            // 
            // GroupBox15
            // 
            this.GroupBox15.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox15.Controls.Add(this.tableLayoutPanel3);
            this.GroupBox15.Controls.Add(this.weatherInfoControl);
            this.GroupBox15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox15.Location = new System.Drawing.Point(42, 305);
            this.GroupBox15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox15.Size = new System.Drawing.Size(531, 224);
            this.GroupBox15.TabIndex = 26;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "Weather";
            // 
            // weatherInfoControl
            // 
            this.weatherInfoControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weatherInfoControl.Location = new System.Drawing.Point(7, 20);
            this.weatherInfoControl.Name = "weatherInfoControl";
            this.weatherInfoControl.Size = new System.Drawing.Size(517, 160);
            this.weatherInfoControl.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.98876F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.01124F));
            this.tableLayoutPanel3.Controls.Add(this.surfCondComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Label105, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 180);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(517, 40);
            this.tableLayoutPanel3.TabIndex = 33;
            // 
            // surfCondComboBox
            // 
            this.surfCondComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surfCondComboBox.BorderColor = System.Drawing.Color.DimGray;
            this.surfCondComboBox.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.surfCondComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfCondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surfCondComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfCondComboBox.FormattingEnabled = true;
            this.surfCondComboBox.Location = new System.Drawing.Point(209, 4);
            this.surfCondComboBox.Name = "surfCondComboBox";
            this.surfCondComboBox.Size = new System.Drawing.Size(247, 31);
            this.surfCondComboBox.TabIndex = 42;
            // 
            // Label105
            // 
            this.Label105.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label105.AutoSize = true;
            this.Label105.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label105.Location = new System.Drawing.Point(4, 8);
            this.Label105.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label105.Name = "Label105";
            this.Label105.Size = new System.Drawing.Size(106, 23);
            this.Label105.TabIndex = 11;
            this.Label105.Text = "RWY Surface";
            // 
            // GroupBox16
            // 
            this.GroupBox16.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox16.Controls.Add(this.resultsRichTxtBox);
            this.GroupBox16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox16.Location = new System.Drawing.Point(42, 537);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new System.Drawing.Size(1084, 238);
            this.GroupBox16.TabIndex = 32;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "Results";
            // 
            // resultsRichTxtBox
            // 
            this.resultsRichTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultsRichTxtBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsRichTxtBox.Location = new System.Drawing.Point(6, 21);
            this.resultsRichTxtBox.Name = "resultsRichTxtBox";
            this.resultsRichTxtBox.ReadOnly = true;
            this.resultsRichTxtBox.Size = new System.Drawing.Size(1073, 245);
            this.resultsRichTxtBox.TabIndex = 33;
            this.resultsRichTxtBox.Text = "";
            // 
            // LandingPerfControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBox13);
            this.Controls.Add(this.GroupBox14);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.GroupBox16);
            this.Controls.Add(this.GroupBox15);
            this.Name = "LandingPerfControl";
            this.Size = new System.Drawing.Size(1144, 818);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.GroupBox GroupBox13;
        internal System.Windows.Forms.GroupBox GroupBox14;
        internal System.Windows.Forms.Button requestBtn;
        internal System.Windows.Forms.Label Label96;
        internal System.Windows.Forms.TextBox appSpdIncTxtBox;
        internal System.Windows.Forms.Label Label97;
        internal System.Windows.Forms.Label Label98;
        internal System.Windows.Forms.Label Label99;
        internal System.Windows.Forms.Label Label100;
        internal System.Windows.Forms.TextBox weightTxtBox;
        internal System.Windows.Forms.Label Label101;
        internal System.Windows.Forms.Label Label102;
        internal System.Windows.Forms.Button calculateBtn;
        internal System.Windows.Forms.GroupBox GroupBox15;
        internal System.Windows.Forms.Label Label105;
        internal System.Windows.Forms.GroupBox GroupBox16;
        internal System.Windows.Forms.RichTextBox resultsRichTxtBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Controls.ComboBoxWithBorder surfCondComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Controls.ComboBoxWithBorder brakeComboBox;
        private Controls.ComboBoxWithBorder revThrustComboBox;
        private Controls.ComboBoxWithBorder wtUnitComboBox;
        private Controls.ComboBoxWithBorder flapsComboBox;
        private Controls.ComboBoxWithBorder acListComboBox;
        private QSP.UI.AirportInfo.AirportInfoControl airportInfoControl;
        private WeatherInfoControl weatherInfoControl;
    }
}
