using System;
using System.Collections;
using System.Collections.Generic;

namespace AdvancedTemplates
{
    public class Person : IEnumerable<Car>, IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private List<Car> cars;

        public Person()
        {
            cars = new List<Car>();
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}\nCars:\n{string.Join("\n", cars)}";
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Person other)
        {
            decimal thisTotalValue = cars.Sum(c => c.Price);
            decimal otherTotalValue = other.cars.Sum(c => c.Price);
            return thisTotalValue.CompareTo(otherTotalValue);
        }
    }
}
