using StoreFrontShared.Models;
using System.Data.Entity;

namespace StoreFrontShared.Data
{
    public class Context : DbContext
    {
        public DbSet<Item> Items { get; set; } //sets "Items" class as an Entity class useable for database connection
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ItemDetails> ItemDetails { get; set; }

        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
