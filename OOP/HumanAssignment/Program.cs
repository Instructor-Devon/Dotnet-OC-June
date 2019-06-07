using System;
using HumanAssignment.Heroes;
namespace HumanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bard = new Human("Dolus");
            Human mage = new Human("Sarus", 100, 2, 4, 50);
            Rogue ninja = new Rogue("Ninjaman");

            Barrel barrel = new Barrel();
            ninja.Sneak();
            ninja.Attack(barrel);



        }
    }
}
