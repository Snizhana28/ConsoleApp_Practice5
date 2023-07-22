using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice5
{
    public class Worker
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private int Salary { get; set; }
        public Worker() { }
        public Worker(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public static Worker operator +(Worker worker, int salary)
        {
            worker.Salary += salary;
            return worker;
        }
        public static Worker operator -(Worker worker, int salary)
        {
            worker.Salary -= salary;
            return worker;
        }
        public static bool operator ==(Worker worker1, Worker worker2)
        {
            return worker1.Salary == worker2.Salary;
        }
        public static bool operator !=(Worker worker1, Worker worker2)
        {
            return worker1.Salary != worker2.Salary;
        }
        public static bool operator >(Worker worker1, Worker worker2)
        {
            return worker1.Salary > worker2.Salary;
        }
        public static bool operator <(Worker worker1, Worker worker2)
        {
            return worker1.Salary < worker2.Salary;
        }
        public override bool Equals(object obj)
        {
            return obj is Worker worker &&
                   Name == worker.Name &&
                   Age == worker.Age &&
                   Salary == worker.Salary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Salary: {Salary}";
        }
    }
}
