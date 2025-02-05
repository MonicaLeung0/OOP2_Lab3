// See https://aka.ms/new-console-template for more information
using OOP2_Lab3;


Console.WriteLine("Enter dog name:");
string dogName = Console.ReadLine();
Dog dog = new Dog();
dog.name = dogName;
dog.colour = "White"; 
dog.age = 7;
Console.WriteLine("Name: "+dog.name);
Console.WriteLine("Colour: " + dog.colour);
Console.WriteLine("Age: " + dog.age);
dog.Eat();


Console.WriteLine("\nEnter cat name:");
string catName = Console.ReadLine();
Cat cat = new Cat(catName, "Black", 3);
Console.WriteLine("Name: " + cat.name);
Console.WriteLine("Colour: " + cat.colour);
Console.WriteLine("Age: " + cat.age);
cat.Eat();

