using System;

namespace OOP
{
    class Mammal
    {
        public static string className = "Mammal";
        public static int numMammals = 0;
        private string name;
        private double weight;
        private bool isFurry;

        public string Name 
        {
            get { return this.name; }
            set
            {
                // names must be at least one character
                if(value.Length > 0)
                    this.name = value;
                else{
                    throw new System.Exception("can't do it!");
                }
            }
        }

        public Mammal(string name, double weight, bool isFurry)
        {
            this.name = name;
            this.weight = weight;
            this.isFurry = isFurry;
            Mammal.numMammals += 1;
        }
        // fields/properties (things mammals all have)
            // name, weight, isFurry
        // methods (things mammals all can do)  
        public virtual void Eat(Mammal target)
        {
            Console.WriteLine($"Yum eatting, {target.name}");
            this.weight += target.weight;
            Mammal.numMammals -= 1;
            target = null;
        }
            // eat, run
        public void Run()
        {
            Console.WriteLine("RUNNING");
            this.weight -= 1;
        }
    }
}