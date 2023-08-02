namespace ConsoleApp_Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.Input();
            Console.WriteLine(city.ToString());
            Console.WriteLine("Enter count of people to add: ");
            int countPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(city + countPeople);
            Console.WriteLine("Enter count of people to subtract: ");
            countPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(city - countPeople);
            City city1 = new City();
            city1.Input();
            Console.WriteLine(city == city1);
            Console.WriteLine(city != city1);
            Console.WriteLine(city < city1);
            Console.WriteLine(city > city1);
        }
    }
}