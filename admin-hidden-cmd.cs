using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ComponentModel;
namespace myprogram
{
    class program
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static void Main()
        {
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
                {
                    string fileName = Assembly.GetExecutingAssembly().Location;
                    ProcessStartInfo processInfo = new ProcessStartInfo();
                    processInfo.Verb = "runas";
                    processInfo.FileName = fileName;

                    try
                    {
                        Process.Start(processInfo);
                    }
                    catch (Win32Exception){}
                    return;
                }
            ProcessStartInfo q = new ProcessStartInfo();
            q.CreateNoWindow = true;
            q.UseShellExecute = false;
            q.RedirectStandardOutput = true;
            q.RedirectStandardError = true;
            q.FileName = @"C:\Windows\system32\cmd.exe";
            q.WorkingDirectory = @"C:\";
            q.Arguments = "/C powershell.exe echo TEST";
            Process processTemp = new Process();
            processTemp.StartInfo = q;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
