using System;

namespace Task_4
{
    class Class1
    {
        static void Main(string[] args)
        {
            SquareMatrix squareMatrix = new SquareMatrix(5);
            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(5);
            Console.WriteLine(squareMatrix.ToString());
            Console.WriteLine(diagonalMatrix.ToString());
        }
    }
}
