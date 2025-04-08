using System;
using System.Collections.Generic;
using System.Linq;

namespace ZooManagement
{
    public class ZooManager
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<IHerbivore> Herbivores { get; set; } = new List<IHerbivore>();
        public List<ICarnivore> Carnivores { get; set; } = new List<ICarnivore>();

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void AddHerbivore(IHerbivore herbivore)
        {
            Herbivores.Add(herbivore);
        }

        public void AddCarnivore(ICarnivore carnivore)
        {
            Carnivores.Add(carnivore);
        }

        public void CopyAnimalsToLists()
        {
            foreach (var animal in Animals)
            {
                if (animal is IHerbivore herbivore)
                {
                    Herbivores.Add(herbivore);
                }
                if (animal is ICarnivore carnivore)
                {
                    Carnivores.Add(carnivore);
                }
            }
        }

        public void FeedAllHerbivores()
        {
            foreach (var herbivore in Herbivores)
            {
                herbivore.FindFood();
                herbivore.EatPlant();
            }
        }

        public void FeedAllCarnivores()
        {
            foreach (var carnivore in Carnivores)
            {
                carnivore.FindFood();
                carnivore.EatMeat();
            }
        }

        public static void FeedHerbivore(IHerbivore herbivore)
        {
            herbivore.FindFood();
            herbivore.EatPlant();
        }

        public static void FeedCarnivore(ICarnivore carnivore)
        {
            carnivore.FindFood();
            carnivore.EatMeat();
        }

        public void DisplayAllAnimals()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        public void DisplayAllHerbivores()
        {
            foreach (var herbivore in Herbivores)
            {
                Console.WriteLine(herbivore.ToString());
            }
        }

        public void DisplayAllCarnivores()
        {
            foreach (var carnivore in Carnivores)
            {
                Console.WriteLine(carnivore.ToString());
            }
        }

        public Animal GetAnimalByName(string name)
        {
            return Animals.FirstOrDefault(a => a.Name == name);
        }
    }
}
