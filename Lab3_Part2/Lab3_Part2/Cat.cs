using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Part2
{
    internal class Cat : IAnimal
    {
        public Cat() { }
        public Cat(string name) 
        {
            this.name = name;
        }
        public string name { get; set; }
        public string colour { get; set; }
        public double height { get; set; }
        public int age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
        public string Cry()
        {
            return "Meow!";
        }
    }
}
