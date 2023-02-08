using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Example
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        internal void Deconstruct(out string name, out int age, out string address)
        {
            name = this.Name;
            age = this.Age;
            address = this.Address;
        }
    }
}
