using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Part2
{
    interface IAnimal
    {

        public string name { get; set; }
        public string colour { get; set;}
        public double height { get; set; }
        public int age { get; set; }

        public abstract void Eat();
        public string Cry();

    }
}
