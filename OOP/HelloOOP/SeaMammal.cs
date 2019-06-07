using System;

namespace OOP
{
    class SeaMammal : Mammal
    {
        // things only sea mammals have
        private double submergeTime;
        public SeaMammal(double submergeTime, string name, double weight) : base(name, weight, false)
        {
            this.submergeTime = submergeTime;
        }

        public override void Eat(Mammal target)
        {
            // we are totally a separate method
            Console.WriteLine("im a sea mammal eating!!");
            base.Eat(target);
        }
    }
}