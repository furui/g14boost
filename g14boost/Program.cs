using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Serilog;
using System.Threading;
using System.Diagnostics;


namespace g14boost
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static private void OnApplicationExit(object sender, EventArgs e)
        {
            // Disable boost on exit
            if(Utility.IsRunningOnBattery())
            {
                PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.AC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.DisabledValueDC.ToString());
            }
            else
            {
                PowerCfg.PowerCfgBroker.SetValueIndex(PowerCfg.ValueIndex.AC, "scheme_current", "sub_processor", "perfboostmode", Properties.Settings.Default.DisabledValueAC.ToString());
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "G14Boost", out createdNew))
            {
                if (createdNew)
                {
                    Log.Logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.RollingFile("logs\\debug.txt", fileSizeLimitBytes: 1000000)
                    .CreateLogger();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.ApplicationExit += new EventHandler(OnApplicationExit);
                    Application.Run(new MainForm());
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            // Normally you would show the main window here but there isn't one for this app
                            break;
                        }
                    }
                }
            }

        }
    }
}
