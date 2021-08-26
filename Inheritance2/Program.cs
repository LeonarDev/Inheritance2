using Inheritance2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Common, user or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = (Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, date));
                }
                else if (ch == 'i')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    productList.Add(new ImportedProduct(name, price, customFee));
                }
                else
                {
                    productList.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product product in productList)
            {
                Console.WriteLine($"{product.PriceTag()}");
            }
        }
    }
}
