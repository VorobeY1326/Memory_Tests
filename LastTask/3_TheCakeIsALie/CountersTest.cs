using System;
using System.Diagnostics;
using System.Threading;

namespace _3_TheCakeIsALie
{
    public abstract class CountersTest
    {
        private readonly int threadsCount;

        protected CountersTest(int threadsCount)
        {
            this.threadsCount = threadsCount;
        }

        protected abstract void AddCounter(int counterId);
        protected abstract string TestName { get; }

        public void Run()
        {
            for (int attempt = 0; attempt < 5; attempt++)
            {
                var threads = new Thread[threadsCount];

                for (int i = 0; i < threadsCount; i++)
                {
                    var counterId = i;
                    threads[i] = new Thread(() => AddCounter(counterId));
                }

                var watch = new Stopwatch();
                watch.Start();

                foreach (var thread in threads)
                    thread.Start();
                foreach (var thread in threads)
                    thread.Join();

                watch.Stop();
                Console.WriteLine(TestName + " time elapsed: " + watch.ElapsedMilliseconds + " ms");
            }
        }
    }
}