using StoreFrontShared.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontShared.Data
{
    internal class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var print1 = new Item()
            {
                Name = "Coast Highway",
                Description = "An image of the Pacific coast from California Highway 1",
                
                Category = "Photography Prints",
                //Image = "",
                
            };

            var detailsPrint1 = new ItemDetails()
            {
                Item = print1,
                Price = 5,
                NumberAvailable = 5
            };

            context.Items.Add(print1);
            context.ItemDetails.Add(detailsPrint1);

            var print2 = new Item()
            {
                Name = "Seattle Waterfront",
                Description = "An image of the Seattle skyline from across Elliott Bay",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print2);

            var print3 = new Item()
            {
                Name = "Snow Pines",
                Description = "An image of pine trees in winter",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            var detailsPrint3 = new ItemDetails()
            {
                Item = print3,
                Price = 7,
                NumberAvailable = 8
            };

            context.Items.Add(print3);
            context.ItemDetails.Add(detailsPrint3);

            var print4 = new Item()
            {
                Name = "Japanese Garden",
                Description = "An image of the Zen garden at the Portland Japanese Garden in Portland, Oregon",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print4);

            var print5 = new Item()
            {
                Name = "Lily Pads",
                Description = "An image of lily pads on a pond",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print5);

            var print6 = new Item()
            {
                Name = "Mount Rainier",
                Description = "An image of Mount Rainier rising above the evergreen forest in Washington State",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print6);

            var print7 = new Item()
            {
                Name = "Mountain and Snow",
                Description = "An image of a mountain in the Olympic Range of Washington State",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print7);

            var print8 = new Item()
            {
                Name = "Seagull",
                Description = "An image of a seagull wading in the small waves at the water's edge",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print8);

            var print9 = new Item()
            {
                Name = "Chickadee",
                Description = "An image of a chickadee perching on the edge of a birdbath with a carved wooden figurine in the center",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print9);

            var print10 = new Item()
            {
                Name = "Sunset Over the Ocean",
                Description = "An image of the sun setting over the water beyond a rocky shore on the Pacific Ocean",
                //Price = 5,
                Category = "Photography Prints",
                //Image = "",
                //NumberAvailable = 5
            };

            context.Items.Add(print10);

            var user1 = new User()
            {
                UserName = "bsachleben",
                Password = "notmyrealpassword",
                Email = "bsachleben@example.com"
            };

            context.Users.Add(user1);

            var order1 = new Order()
            {
                Client = "bsachleben",
                Item = print1,
                Quantity = 1,
                Date = new DateTime(2017, 1, 1),
            };

            context.Orders.Add(order1);

            context.SaveChanges();
        }
    }
}
