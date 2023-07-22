namespace ConsoleApp_Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Alex", 22 , 25000);
            Worker worker2 = new Worker("Bob", 25, 30000);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(worker1);
            Console.WriteLine(worker2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Overloaded operators + and -");
            worker1 = worker1 + 5000;
            worker2 = worker2 - 5000;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(worker1);
            Console.WriteLine(worker2);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Overloaded operators == and !=");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(worker1 == worker2);
            Console.WriteLine(worker1 != worker2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Overloaded operators > and <");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(worker1 > worker2);
            Console.WriteLine(worker1 < worker2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Overloaded Equals");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(worker1.Equals(worker2));
            Console.ResetColor();
        }
    }
}