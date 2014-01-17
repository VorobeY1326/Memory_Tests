using System;
using System.Collections.Generic;
namespace _4_Matrix
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            const int size = 1024;
            const int blockSizeLog = 3;

            var usualTest = new UsualMatrixTest(size);
            usualTest.Run();

            var superTest = new SuperMatrixTest(size, blockSizeLog);
            superTest.Run();
        }
    }
}
