using System;
using System.Collections.Generic;

namespace AdvancedTemplates
{
    public class Car
    {
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Car(string brand, decimal price)
        {
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} - {Price:C}";
        }
    }
}