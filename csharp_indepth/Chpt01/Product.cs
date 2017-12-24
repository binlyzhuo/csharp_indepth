using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt01
{
    public class Product
    {
        //private string name;
        public string Name { set; get; }

        //private decimal price;

        public decimal Price { set; get; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}:{Price}";
        }

        public static List<Product> GetSampleProducts()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story",9.9m));
            list.Add(new Product("Assassins",14.9m));
            list.Add(new Product("Frogs",13.9m));
            list.Add(new Product("Sweeney Todd",10.99m));
            return list;
        }
    }
}
