using System;

namespace ZooManagement
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        protected Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Name}, Age: {Age}, Weight: {Weight} kg";
        }
    }
}
