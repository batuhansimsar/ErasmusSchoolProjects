using System;

namespace ZooManagement
{
    public class Sheep : Animal, IHerbivore
    {
        public Sheep(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} the sheep is looking for grass...");
        }

        public void EatPlant()
        {
            Console.WriteLine($"{Name} the sheep is eating grass.");
        }
    }
}
