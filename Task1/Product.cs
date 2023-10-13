using System.Diagnostics;
using System.Xml.Linq;

namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Product otherProduct)
            {
                return Name == otherProduct.Name && Price == otherProduct.Price;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Name, Price).GetHashCode();
        }
    }    
}
