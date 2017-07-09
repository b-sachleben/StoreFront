using StoreFrontShared.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StoreFrontShared.Data
{
    public class Context : DbContext
    {
        public DbSet<Item> Items { get; set; } //sets "Items" class as an Entity class useable for database connection
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ItemDetails> ItemDetails { get; set; }
        public DbSet<ItemWithDetails> ItemWithDetails { get; set; }

        //public Context()
        //{
        //    Database.SetInitializer(new DatabaseInitializer());
        //}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
