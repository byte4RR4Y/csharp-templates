using System;
using System.Diagnostics;


namespace hidecmd
{
    class Program
    {
        static void Main()
        {
            ProcessStartInfo q = new ProcessStartInfo();
            q.CreateNoWindow = true;
            q.UseShellExecute = false;
            q.RedirectStandardOutput = true;
            q.RedirectStandardError = true;
            q.FileName = @"C:\Windows\system32\cmd.exe";
            q.WorkingDirectory = @"C:\";
            q.Arguments = @"/C echo ""hallo"" > hallo.txt";
            Process processTemp = new Process();
            processTemp.StartInfo = q;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
