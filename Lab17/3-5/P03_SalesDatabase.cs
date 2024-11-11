using P03_SalesDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase
{
   class Program
   {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new SalesContext())
                {
                   Seed(context);
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Done!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ex.InnerException?.Message);
                Console.ResetColor();
            }
        }

        static void Seed(SalesContext context)
        {
            Random random = new Random();
            var products = new List<Product>();
            var stores = new List<Store>();
            var customers = new List<Customers>();

            for (int i = 1; i <= 10; i++)
            {
                var product = new Product
                {
                    Name = $"Product #{i}",
                    Quantity = random.Next(1, 99),
                    Price = random.Next(100, 999),
                };
                products.Add(product); 
                context.Products.Add(product); 
            }

            for (int i = 1; i <= 10; i++)
            {
                var store = new Store
                {
                    Name = $"Store #{i}"
                };
                stores.Add(store); 
                context.Stores.Add(store); 
            }

            for (int i = 1; i <= 10; i++)
            {
                var customer = new Customers
                {
                    Name = $"Customer {i}",
                    Email = $"customer{i}@example.com",
                    CreditCardNumber = $"1234-{random.Next(1000, 9999)}-{random.Next(1000, 9999)}-{random.Next(1000, 9999)}"
                };
                customers.Add(customer); 
                context.Customers.Add(customer); 
            }

           
            context.SaveChanges();
        }



   }

}

