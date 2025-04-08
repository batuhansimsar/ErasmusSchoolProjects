using System;
using System.Collections.Generic;

namespace AdvancedTemplates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test GenericMethods
            Console.WriteLine("Testing Generic Methods:");
            
            // Test Swap
            int a = 5, b = 10;
            Console.WriteLine($"Before swap: a={a}, b={b}");
            GenericMethods.Swap(ref a, ref b);
            Console.WriteLine($"After swap: a={a}, b={b}");

            // Test DisplayTypes
            GenericMethods.DisplayTypes("Hello", 42);

            // Test CreateInstance
            var person = GenericMethods.CreateInstance<Person>();
            Console.WriteLine($"Created new person: {person}");

            // Test GetLarger
            int larger = GenericMethods.GetLarger(15, 10);
            Console.WriteLine($"Larger number: {larger}");

            // Test SortParameters
            var sorted = GenericMethods.SortParameters(5, 2, 8, 1, 9);
            Console.WriteLine("Sorted numbers: " + string.Join(", ", sorted));

            // Test CreateDictionary
            var dict = GenericMethods.CreateDictionary(1, "One");
            GenericMethods.DisplayDictionary(dict);

            // Test CreateCollection
            var collection = GenericMethods.CreateCollection(1, 2, 3, 4);
            Console.WriteLine("Collection type: " + collection.GetType().Name);

            // Test Person class
            Console.WriteLine("\nTesting Person class:");
            var person1 = new Person("John", "Doe", 30);
            person1.AddCar(new Car("Toyota", 25000));
            person1.AddCar(new Car("Honda", 20000));

            var person2 = new Person("Jane", "Smith", 25);
            person2.AddCar(new Car("BMW", 45000));

            Console.WriteLine(person1);
            Console.WriteLine(person2);

            // Test Quadruple class
            Console.WriteLine("\nTesting Quadruple class:");
            var quad1 = new Quadruple<int, string, double, bool>(1, "First", 1.5, true);
            var quad2 = new Quadruple<int, string, double, bool>(2, "Second", 2.5, false);
            
            Console.WriteLine(quad1);
            Console.WriteLine(quad2);

            var quads = new List<Quadruple<int, string, double, bool>> { quad2, quad1 };
            quads.Sort();
            Console.WriteLine("Sorted Quadruples:");
            foreach (var quad in quads)
            {
                Console.WriteLine(quad);
            }
        }
    }
}
