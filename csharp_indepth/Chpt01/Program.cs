using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt01
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Product.GetSampleProducts();
            //products.Sort(new ProductNameComparer());

            //products.Sort(delegate(Product x, Product y) { return x.Name.CompareTo(y.Name); });

            Predicate<Product> test = delegate(Product product) { return product.Price > 10m;  };

            var matches= products.FindAll(test);

            Action<Product> print = Console.WriteLine;

            Print(matches);
            Console.ReadLine();

        }

        static void Print(List<Product> products)
        {
            foreach (var product in products.OrderBy(p=>p.Name))
            {
                Console.WriteLine(product);
            }
        }
    }
}
