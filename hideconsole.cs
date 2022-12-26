using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MyHideConsole{
    class Program{
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void Main(string[] args){
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            ShowWindow(h, 0);

           // YOUR PROGRAM HERE
        }
    }
}

