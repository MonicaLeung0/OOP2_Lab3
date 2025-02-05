using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Lab3
{
    abstract class Animal
    {
        public string name { get; set; }
        public string colour { get; set; }
        public int age { get; set; }

        public Animal() { }

        public Animal(string name, string colour, int age) {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }
        public abstract void Eat();


    }
}
