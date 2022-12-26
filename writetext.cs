using System;
using System.IO;

namespace WriteText
{
    class Program
    {
        public static void Main(string[] args)
        {
            string writetext = @"write ""HKLM:\SYSTEM\mykey"" to this file";
            File.WriteAllText("test.ps1", writetext);
        }
    }
}
