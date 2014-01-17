using System;
using System.Diagnostics;
using System.Threading;
using _1_Multiple_Common;

namespace LastTask
{
    public class ProcessesTest
    {
        private readonly Process[] processes;

        public ProcessesTest(int threadsCount)
        {
            processes = new Process[threadsCount];
        }

        public void Run()
        {
            var watch = new Stopwatch();
            watch.Start();

            for (int i=0; i<processes.Length; i++)
            {
                processes[i] = Process.Start(new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    FileName = @"..\..\..\1_Multiple_Process\bin\Debug\1_Multiple_Process.exe"
                });
            }

            foreach (var process in processes)
                process.WaitForExit();

            watch.Stop();
            Console.WriteLine("Processes Time Elapsed: " + watch.ElapsedMilliseconds + " ms");
        } 
    }
}