/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImagXpressDemo
{
    static class Program
    {
        [DllImport(Constants.user32String)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ensure only 1 instance of the application is run
            if (!Program.IsDemoAlreadyRunning())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        public static bool IsDemoAlreadyRunning()
        {
            Process[] processes = Process.GetProcesses();
            Process currentProcess = Process.GetCurrentProcess();

            foreach (Process process in processes)
            {
                string processName = process.ProcessName;

                /*Ensure the duplicate process we're looking for is not the current one by checking the id's
                aren't the same, and the names should be the same.*/
                if (String.Equals(processName, currentProcess.ProcessName) && currentProcess.Id != process.Id)
                {
                    /*bring the main window of the already running demo to the foreground so the user sees
                    an instance is already running*/
                    SetForegroundWindow(process.MainWindowHandle);

                    //only 1 instance of the demo is allowed to run
                    return true;
                }
            }

            //no another instance of the demo was found
            return false;
        }
    }
}
