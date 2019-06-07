using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal bear = new Mammal("Pooh", 23.3, true);
            SeaMammal whale = new SeaMammal(50, "Willie", 2343.3);

            User devon = new User()
            {
                Name = "Devon",
                Age = 100
            };

            User matt = new User();
            matt.Name = "Matt";
            matt.Age = 20;
            

            whale.Eat(bear);


            Console.WriteLine(Mammal.numMammals); // => "Mammal"
        }
    }
}
