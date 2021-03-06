﻿using QSP.Common.Options;
using QSP.Properties;
using QSP.UI.Forms;
using QSP.UI.MsgBox;
using QSP.Updates;
using QSP.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static QSP.Updates.Utilities;

namespace QSP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main(string[] args)
        {
#if !DEBUG
            // Only allows starting from launcher. Otherwise data loss might occur because of
            // the updater.
            try
            {
                var latest = UsingLatestVersion();
                if (!latest)
                {
                    MsgBoxHelper.ShowError(null, "Please start QSimPlanner via Launcher.exe.");
                    return;
                }
            }
            catch (Exception e)
            {
                MsgBoxHelper.ShowError(null, "An error occurred.\n" + e.Message);
                return;
            }
#endif
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            using (var mutex = new Mutex(false, $"Global\\{GetGuid()}"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MsgBoxHelper.ShowError(null, "QSimPlanner is already running.");
                    return;
                }

                SetExceptionHandler();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
#if !DEBUG
                UpdateOnFirstRun();
#endif
                var mainFrm = new QspForm();
                mainFrm.Init();

                Application.Run(mainFrm);
            }
        }

        // @Throws
        private static bool UsingLatestVersion()
        {
            var ver = GetVersions();
            var dir = new DirectoryInfo(Path.GetFullPath(Directory.GetCurrentDirectory())).Name;
            return ver.Backup == "" || ver.Current == dir;
        }

        private static void UpdateOnFirstRun()
        {
            if (!IsFirstLaunch()) return;

            using (var form = new Splash())
            {
                form.ShowInTaskbar = true;
                form.Icon = Resources.qsp_icon;
                form.SmallTitleLbl.Text = "Checking for updates ...";
                form.SmallTitleLbl.Font =
                    new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);

                form.Shown += (s, e) =>
                {
                    form.Refresh();

                    var status = new Updater().Update();
                    if (status.Status == Updater.Status.Success)
                    {
                        form.Close();
                        MsgBoxHelper.ShowInfo(null, "QSimPlanner has been successfully updated" +
                            " and will restart now.");
                        StartLauncher();
                        Environment.Exit(0);
                    }

                    form.Close();
                };

                form.ShowDialog();
            }
        }

        // Returns whether this is the first time user starts the application.
        // If failed to read files, returns false.
        private static bool IsFirstLaunch()
        {
            if (File.Exists(OptionManager.DefaultPath)) return false;

            // If option file does not exist, it can be:
            // (1) This is the first time user lauches the app. or
            // (2) The app just updated an the post-update action has not run.
            try
            {
                return GetVersions().Backup == "";
            }
            catch
            {
                return false;
            }
        }

        private static void StartLauncher()
        {
            var info = new ProcessStartInfo()
            {
                WorkingDirectory = "..",
                FileName = "Launcher.exe",
                Arguments = "-wait"
            };

            if (Environment.OSVersion.Version.Major >= 6) info.Verb = "runas";
            Process.Start(info);
        }

        private static void SetExceptionHandler()
        {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                HandleException((Exception)e.ExceptionObject);

            Application.ThreadException += (s, e) => HandleException(e.Exception);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        }

        private static void HandleException(Exception ex)
        {
            LoggerInstance.Log(ex);

            var frm = new UnhandledExceptionForm();
            frm.Init(ex.ToString());
            frm.ShowDialog();

            Environment.Exit(1);
        }

        private static string GetGuid()
        {
            var attributes = typeof(Program).Assembly
                .GetCustomAttributes(typeof(GuidAttribute), true);

            return ((GuidAttribute)attributes[0]).Value;
        }
    }
}