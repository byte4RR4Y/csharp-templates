using System;
using System.Security.Principal;
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection;

namespace adminprivs
{
    class Program
    {
        static void Main()
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
            {

                // relaunch the application with admin rights
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
            // YOUR PROGRAM HERE
        }
    }
}
