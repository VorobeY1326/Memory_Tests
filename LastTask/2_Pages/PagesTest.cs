using System;
using System.Diagnostics;

namespace _2_Pages
{
    public class PagesTest
    {
        private readonly byte[] array;
        private const int attempts = 50*1000*1000; 

        public PagesTest(byte[] array)
        {
            this.array = array;
        }

        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                var watch = new Stopwatch();

                watch.Start();
                RightOrder();
                watch.Stop();
                Console.WriteLine("Right order: " + watch.ElapsedMilliseconds + " ms");

                watch.Restart();
                RandomOrder();
                watch.Stop();
                Console.WriteLine("Random order: " + watch.ElapsedMilliseconds + " ms");
            }
        }

        private void RightOrder()
        {
            var random = new Random();
            for (int i = 0; i < attempts; i++)
                array[i] = (byte) random.Next(0, 255);
        }

        private void RandomOrder()
        {
            var random = new Random();
            for (int i = 0; i < attempts; i++)
            {
                var rand = random.Next(0, array.Length);
                array[rand] = (byte) rand;
            }
        }
    }
}