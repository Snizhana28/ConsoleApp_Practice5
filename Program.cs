namespace ConsoleApp_Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 3);
            Matrix matrix2 = new Matrix(3, 3);

            matrix1.FillingRandom();
            matrix2.FillingRandom();
            Console.WriteLine("Matrix 1:");
            matrix1.Output();
            Console.WriteLine("Matrix 2:");
            matrix2.Output();

            // Overloaded operator +
            Matrix matrix3 = matrix1 + matrix2;
            Console.WriteLine("Matrix 3 = Matrix 1 + Matrix 2:");
            matrix3.Output();
            // Overloaded operator -
            Matrix matrix4 = matrix1 - matrix2;
            Console.WriteLine("Matrix 4 = Matrix 1 - Matrix 2:");
            matrix4.Output();
            // Overloaded operator *
            Matrix matrix5 = matrix1 * matrix2;
            Console.WriteLine("Matrix 5 = Matrix 1 * Matrix 2:");
            matrix5.Output();
            // Overloaded operator * (int)
            Matrix matrix6 = matrix1 * 2;
            Console.WriteLine("Matrix 6 = Matrix 1 * 2:");
            matrix6.Output();
            // Overloaded operator ==
            Console.WriteLine("Matrix 1 == Matrix 2: " + (matrix1 == matrix2));
            Console.WriteLine("Matrix 1 == Matrix 1: " + (matrix1 == matrix1));
            // Overloaded operator !=
            Console.WriteLine("Matrix 1 != Matrix 2: " + (matrix1 != matrix2));
            Console.WriteLine("Matrix 1 != Matrix 1: " + (matrix1 != matrix1));
        }
    }
}