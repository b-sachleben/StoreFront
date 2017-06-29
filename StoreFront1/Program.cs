using StoreFrontShared.Data;
using StoreFrontShared.Models;
using System;
using System.Linq;
using System.Data.Entity;

namespace StoreFront1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context()) //opens database connection using "Context" class
            {
                //context.Items.Add(new Item()
                //{
                //    Name = "Coast Highway",
                //    Description = "An image of the Pacific coast from California Highway 1",
                //    Price = 5,
                //    Category = "Photography Prints",
                //    //Image = "",
                //    NumberAvailable = 5
                //}); //instantiates new item to store in database

                //context.SaveChanges(); //saves changes to database

                var items = context.Items.ToList();
                foreach (var item in items) //iterate through "Items" database items
                {
                    Console.WriteLine("Name: " + item.Name);
                    Console.WriteLine("Description: " + item.Description);
                    //Console.WriteLine("Price: " + item.Price);
                    Console.WriteLine();
                }

                Console.ReadLine();

                var orders = context.Orders
                    .Include(o => o.Item) //includes "Item" object in "Orders" class
                    .ToList();
                foreach (var order in orders) //iterate through "Items" database items
                {
                    Console.WriteLine("User: " + order.Client);
                    Console.WriteLine("Product: " + order.Item.Name);
                    Console.WriteLine("Quantity: " + order.Quantity);
                    Console.WriteLine();
                }

                Console.ReadLine(); //keeps console open until enter key is pressed
            }
        }
    }
}
