using System;
using System.Diagnostics;

namespace _4_Matrix
{
    public class SuperMatrixTest
    {
        private readonly int matrixSize;
        private readonly IMatrix matrixA;
        private readonly IMatrix matrixB;
        private readonly IMatrix matrixC;

        public SuperMatrixTest(int matrixSize, int blockSizeLog)
        {
            this.matrixSize = matrixSize;

            matrixA = new SuperMatrix(matrixSize, blockSizeLog);
            matrixB = new SuperMatrix(matrixSize, blockSizeLog);
            matrixC = new SuperMatrix(matrixSize, blockSizeLog);

            MatrixFiller.FillRandomly(matrixA, matrixSize);
            MatrixFiller.FillRandomly(matrixB, matrixSize);
        }

        public void Run()
        {
            var watch = new Stopwatch();
            watch.Start();
            MatrixMulti.Multipy(matrixA, matrixB, matrixC, matrixSize);
            watch.Stop();
            Console.WriteLine("SUPER matrix time: " + watch.ElapsedMilliseconds + " ms");
        } 
    }
}