using System;
using System.Text;

namespace Task_4
{
    class SquareMatrix
    {
        public int Size { get; }
        protected int[] matrix;

        public SquareMatrix(int size)
        {
            Size = size;
            matrix = new int[Size * Size];
            InitializeRandom();
        }
        public void InitializeRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrix[i * Size + j] = rnd.Next(10);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    str.Append(matrix[i * Size + j]);
                    str.Append(" ");
                }
                str.Append("\n");
            }
            return str.ToString();
        }
    }
}
