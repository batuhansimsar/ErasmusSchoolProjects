using System;

namespace ZooManagement
{
    public class Pig : Animal, IHerbivore, ICarnivore
    {
        public Pig(string name, int age, double weight) : base(name, age, weight)
        {
        }

        void IHerbivore.FindFood()
        {
            Console.WriteLine($"{Name} the pig is looking for vegetables...");
        }

        void ICarnivore.FindFood()
        {
            Console.WriteLine($"{Name} the pig is looking for meat scraps...");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{Name} the pig is eating vegetables.");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{Name} the pig is eating meat scraps.");
        }
    }
}
