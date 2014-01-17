using System.Threading;

namespace _4_Matrix
{
    public static class MatrixMulti
    {
        private const int threadsCount = 4;

        public static void Multipy(IMatrix a, IMatrix b, IMatrix result, int size)
        {
            var threads = new Thread[threadsCount];
            for (int i = 0; i < threadsCount; i++)
            {
                var threadId = i;
                threads[i] = new Thread(() => FillLines(a, b, result, size, threadId));
            }
            foreach (var thread in threads)
                thread.Start();
            foreach (var thread in threads)
                thread.Join();
        }

        private static void FillLines(IMatrix a, IMatrix b, IMatrix result, int size, int threadId)
        {
            for (int i = 0; i < size/threadsCount; i++)
                FillLine(a, b, result, size, threadId + i*threadsCount);
        }

        private static void FillLine(IMatrix a, IMatrix b, IMatrix result, int size, int lineId)
        {
            for (int cellId = 0; cellId < size; cellId++)
            {
                for (int j = 0; j < size; j++)
                    result.Set(lineId, cellId, result.Get(lineId, cellId) + a.Get(lineId, j) * b.Get(j, cellId));
            }
        }
    }
}