using System;
using System.Collections.Generic;

namespace _1_Multiple_Common
{
    public class TestingProcedure
    {
        private const int count = 2500000;

        private readonly IList<byte[]> blocks = new List<byte[]>();
        private readonly Random random = new Random();

        public void Run()
        {
            for (int i=0; i<count; i++)
                DoRandomAction();
        }

        private void DoRandomAction()
        {
            var probability = random.NextDouble();
            if (probability < ((double)1/3))
                AddBlock();
            else if (probability < ((double)2/3))
                RemoveBlock();
            else
                WriteToBlock();
        }

        private void AddBlock()
        {
            var size = random.Next(256, 4*256);
            var block = new byte[size];
            blocks.Add(block);
        }

        private void RemoveBlock()
        {
            if (blocks.Count > 0)
            {
                var id = random.Next(0, blocks.Count);
                blocks.RemoveAt(id);
            }
        }

        private void WriteToBlock()
        {
            if (blocks.Count > 0)
            {
                var id = random.Next(0, blocks.Count);
                var address = random.Next(0, blocks[id].Length);
                blocks[id][address] = (byte) random.Next(0, 255);
            }
        }
    }
}