namespace HumanAssignment.Heroes
{
    class Human : IDamagable
    {
        // Fields for Human
        public string Name {get;set;}
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        // add a public "getter" property to access health
        public int Health {get;set;}
        private int numKills;
        
        // Add a constructor that takes value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            this.Name = name;
            this.Strength = 3;
            this.Intelligence = 3;
            this.Dexterity = 3;
            this.health = 100;
            this.numKills = 0;
        }
        
        // Add a constructor to assign custom values to all fields
        public Human(string name, int intel, int str, int dex, int health)
        {
            this.Name = name;
            this.Intelligence = intel;
            this.Strength = str;
            this.Dexterity = dex;
            this.health = health;
        }
        
        // Build Attack method
        public virtual int Attack(IDamagable target, int dmgBonus = 0)
        {
            /*
            Now add a new method called Attack, which when invoked, 
            should reduce the health of a Human object that is passed as a parameter. 
            The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker). 
            This method should return the remaining health of the target object */

            int dmg = 5 * this.Strength + dmgBonus;

            // did we kill target?
            if(target.Health - dmg <= 0){
                target.Health = 0;
                System.Console.WriteLine($"{target.Name} has expired.");
                this.numKills++;
            }
            else
                target.Health -= dmg;

            return target.Health;
        }
    }
}