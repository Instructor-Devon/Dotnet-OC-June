using System;
namespace HumanAssignment.Heroes
{
    class Rogue : Human
    {
        // lots of dex, a little squishy(not much health), not very strong, avg int
        public bool isSneaking;
        public Rogue(string name) : base(name, 2, 3, 8, 80)
        {
            isSneaking = false;
        }

        public bool Sneak()
        {
            // roll
            Random roll = new Random();
            bool didSneak = (roll.Next(20) + this.Dexterity) > 13;

            if(didSneak)
                isSneaking = true;
            return didSneak;
        }

        // Rogue can attack like a Rogue!!!!
        public override int Attack(IDamagable target, int bonus = 0)
        {
            if(this.isSneaking) {
                // calculate crit dmg
                int critDmg = 10;
                return base.Attack(target, critDmg);
            }
            else{
                return base.Attack(target);
            }
        }

    }
}