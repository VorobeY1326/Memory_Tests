namespace _4_Matrix
{
    public class SuperMatrix : IMatrix
    {
        private readonly int[,,,] matrix;
        private readonly int blockSizeLog;
        private readonly int blockSizeMinus1;

        public SuperMatrix(int size, int blockSizeLog)
        {
            this.blockSizeLog = blockSizeLog;
            var blockSize = (1 << blockSizeLog);
            this.blockSizeMinus1 = blockSize - 1;
            matrix = new int[size/blockSize, size/blockSize, blockSize, blockSize];
        }

        public void Set(int i, int j, int value)
        {
            matrix[i >> blockSizeLog, j >> blockSizeLog, i & blockSizeMinus1, j & blockSizeMinus1] = value;
        }

        public int Get(int i, int j)
        {
            return matrix[i >> blockSizeLog, j >> blockSizeLog, i & blockSizeMinus1, j & blockSizeMinus1];
        }
    }
}