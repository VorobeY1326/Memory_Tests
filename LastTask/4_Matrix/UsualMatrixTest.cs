using System;
using System.Diagnostics;

namespace _4_Matrix
{
    public class UsualMatrixTest
    {
        private readonly int matrixSize;
        private readonly IMatrix matrixA;
        private readonly IMatrix matrixB;
        private readonly IMatrix matrixC;

        public UsualMatrixTest(int matrixSize)
        {
            this.matrixSize = matrixSize;

            matrixA = new UsualMatrix(matrixSize);
            matrixB = new UsualMatrix(matrixSize);
            matrixC = new UsualMatrix(matrixSize);

            MatrixFiller.FillRandomly(matrixA, matrixSize);
            MatrixFiller.FillRandomly(matrixB, matrixSize);
        }

        public void Run()
        {
            var watch = new Stopwatch();
            watch.Start();
            MatrixMulti.Multipy(matrixA, matrixB, matrixC, matrixSize);
            watch.Stop();
            Console.WriteLine("Usual matrix time: " + watch.ElapsedMilliseconds + " ms");
        }
    }
}