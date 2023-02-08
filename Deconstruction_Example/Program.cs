using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Adam", 33, "Bakonyszombathely");

            (string name, int age, string address) = p;

            Console.WriteLine(name + ", " + age + ", " + address);
            Console.ReadKey();
        }
    }
}
