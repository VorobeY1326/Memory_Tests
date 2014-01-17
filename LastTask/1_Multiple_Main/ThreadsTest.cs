using System;
using System.Diagnostics;
using System.Threading;
using _1_Multiple_Common;

namespace LastTask
{
    public class ThreadsTest
    {
        private readonly Thread[] threads;

        public ThreadsTest(int threadsCount)
        {
            threads = new Thread[threadsCount];
            for (int i = 0; i < threadsCount; i++)
            {
                var procedure = new TestingProcedure();
                threads[i] = new Thread(procedure.Run);
            }
        }

        public void Run()
        {
            var watch = new Stopwatch();
            watch.Start();

            foreach (var thread in threads)
                thread.Start();
            foreach (var thread in threads)
                thread.Join();

            watch.Stop();
            Console.WriteLine("Threads Time Elapsed: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}