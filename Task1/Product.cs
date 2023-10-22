using System;
using System.Runtime;
using System.Diagnostics;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Task1
{
    public class Product : IEquatable<Product>
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool Equals(Product otherProduct)
        {
            if (otherProduct != null)
            {
                return Name == otherProduct.Name && Price == otherProduct.Price;
            }
            return false;
        }
    }    
}
