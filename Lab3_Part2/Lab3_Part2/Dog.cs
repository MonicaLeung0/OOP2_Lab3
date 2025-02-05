using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Part2
{
    internal class Dog : IAnimal
    {
        public Dog() { }
        public Dog(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
        public string colour { get; set; }
        public double height { get; set; }
        public int age { get; set; }

        public void Eat() 
        {
            Console.WriteLine("Dogs eat meat");
        }
        public string Cry() 
        {
            return "Woof!";
        }
    }
}
