using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice5
{
    public class City
    {
        private string nameCity;
        private string nameCountry;
        private int countPeople;
        public string NameCity { get; set; }
        public string NameCountry { get; set; }
        public int CountPeople { get; set; }
        public City()
        {
            nameCity = "Kyiv";
            nameCountry = "Ukraine";
            countPeople = 3000000;
        }
        public City(string nameCity, string nameCountry, int countPeople)
        {
            this.nameCity = nameCity;
            this.nameCountry = nameCountry;
            this.countPeople = countPeople;
        }
        public void Input()
        {
            Console.WriteLine("Enter name of city: ");
            nameCity = Console.ReadLine();
            Console.WriteLine("Enter name of country: ");
            nameCountry = Console.ReadLine();
            Console.WriteLine("Enter count of people: ");
            countPeople = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Name of city: " + nameCity + "\nName of country: " + nameCountry + "\nCount of people: " + countPeople;
        }
        public static City operator +(City city, int countPeople)
        {
            city.countPeople += countPeople;
            return city;
        }
        public static City operator -(City city, int countPeople)
        {
            city.countPeople -= countPeople;
            return city;
        }
        public static bool operator ==(City city1, City city2)
        {
            return city1.countPeople == city2.countPeople;
        }
        public static bool operator !=(City city1, City city2)
        {
            return city1.countPeople != city2.countPeople;
        }
        public static bool operator <(City city1, City city2)
        {
            return city1.countPeople < city2.countPeople;
        }
        public static bool operator >(City city1, City city2)
        {
            return city1.countPeople > city2.countPeople;
        }
    }
}
