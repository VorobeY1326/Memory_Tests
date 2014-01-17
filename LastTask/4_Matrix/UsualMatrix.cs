namespace _4_Matrix
{
    public class UsualMatrix : IMatrix
    {
        private readonly int[,] matrix;

        public UsualMatrix(int size)
        {
            matrix = new int[size, size];
        }

        public void Set(int i, int j, int value)
        {
            matrix[i, j] = value;
        }

        public int Get(int i, int j)
        {
            return matrix[i, j];
        }
    }
}