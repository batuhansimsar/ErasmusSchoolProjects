using System;

namespace ZooManagement
{
    public class Wolf : Animal, ICarnivore
    {
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public void FindFood()
        {
            Console.WriteLine($"{Name} the wolf is hunting for prey...");
        }

        public void EatMeat()
        {
            Console.WriteLine($"{Name} the wolf is eating meat.");
        }
    }
}
