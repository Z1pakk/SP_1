using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Process notepadProcess = new Process();
            notepadProcess.StartInfo = new ProcessStartInfo(
                "ipconfig.exe");
            //notepadProcess.StartInfo.UseShellExecute = false;
            //notepadProcess.Start();

            foreach (var item in Process.GetProcesses())
            {
                Console.WriteLine($"{ item.Id }, { item.ProcessName }");
            }

            var findedProcess = Process.GetProcessesByName("Teams");
            foreach (var item in findedProcess)
            {
                item.Kill();
            }

            Console.ReadLine();
        }
    }
}
