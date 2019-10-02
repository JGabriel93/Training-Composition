using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Training_Composition.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product()
        {

        }
        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
