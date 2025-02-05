// See https://aka.ms/new-console-template for more information
using Lab3_Part2;
List<IAnimal> animals = new List<IAnimal>();

Console.WriteLine("Enter dog name:");
string dogName = Console.ReadLine();
Dog dog = new Dog(dogName);
Console.WriteLine("Enter dog color:");
string dogColour = Console.ReadLine();
dog.colour = dogColour;
Console.WriteLine("Enter dog Height:");
double dogHieght = Convert.ToDouble(Console.ReadLine());
dog.height = dogHieght;
Console.WriteLine("Enter dog age:");
int dogAge = Convert.ToInt32(Console.ReadLine());
dog.age = dogAge;
Console.WriteLine("Name: " + dog.name);
Console.WriteLine("Colour: " + dog.colour);
Console.WriteLine("Height: " + dog.height);
Console.WriteLine("Age: " + dog.age);
dog.Eat();
Console.WriteLine(dog.Cry() + "\n");

Console.WriteLine("Enter cat name:");
string catName = Console.ReadLine();
Cat cat = new Cat(catName);
Console.WriteLine("Enter cat color:");
string catColour = Console.ReadLine();
cat.colour = catColour;
Console.WriteLine("Enter cat Height:");
double catHieght = Convert.ToDouble(Console.ReadLine());
cat.height = catHieght;
Console.WriteLine("Enter cat age:");
int catAge = Convert.ToInt32(Console.ReadLine());
cat.age = catAge;
Console.WriteLine("Name: " + cat.name);
Console.WriteLine("Colour: " + cat.colour);
Console.WriteLine("Age: " + cat.height);
Console.WriteLine("Age: " + cat.age);
cat.Eat();
Console.WriteLine(cat.Cry() + "\n");

Dog dog2 = new Dog("Puppy");
Cat cat2 = new Cat("Kitty");

Console.WriteLine("Name List:");

animals.Add(dog);
animals.Add(cat);
animals.Add(dog2);
animals.Add(cat2);
for (int i = 0; i< animals.Count; i++) 
{
    Console.WriteLine(animals[i].name);
}


