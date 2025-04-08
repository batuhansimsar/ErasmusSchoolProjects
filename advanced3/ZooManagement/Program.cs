using System;

namespace ZooManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var zooManager = new ZooManager();

            // Create animals
            var sheep = new Sheep("Shaun", 3, 45.5);
            var wolf = new Wolf("Alpha", 5, 70.0);
            var pig = new Pig("Peppa", 2, 120.0);

            // Add animals to the main list
            zooManager.AddAnimal(sheep);
            zooManager.AddAnimal(wolf);
            zooManager.AddAnimal(pig);

            // Copy animals to their respective lists
            zooManager.CopyAnimalsToLists();

            // Display all animals
            Console.WriteLine("All Animals:");
            zooManager.DisplayAllAnimals();
            Console.WriteLine();

            // Display herbivores
            Console.WriteLine("Herbivores:");
            zooManager.DisplayAllHerbivores();
            Console.WriteLine();

            // Display carnivores
            Console.WriteLine("Carnivores:");
            zooManager.DisplayAllCarnivores();
            Console.WriteLine();

            // Feed all herbivores
            Console.WriteLine("Feeding all herbivores:");
            zooManager.FeedAllHerbivores();
            Console.WriteLine();

            // Feed all carnivores
            Console.WriteLine("Feeding all carnivores:");
            zooManager.FeedAllCarnivores();
            Console.WriteLine();

            // Feed individual animals
            Console.WriteLine("Feeding individual animals:");
            ZooManager.FeedHerbivore(sheep);
            ZooManager.FeedCarnivore(wolf);
            ZooManager.FeedHerbivore(pig);
            ZooManager.FeedCarnivore(pig);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
