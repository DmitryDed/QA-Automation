using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RightTriangleBuilder rightTriangleBuilder = new RightTriangleBuilder();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}