using System;

namespace _4_Matrix
{
    public static class MatrixFiller
    {
        public static void FillRandomly(IMatrix a, int size)
        {
            var rand = new Random();
            for (int j=0; j<size; j++)
                for (int i=0; i<size; i++)
                    a.Set(i,j, rand.Next(0, 16));
        }
    }
}