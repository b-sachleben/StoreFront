using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontShared.Models
{
    public class ItemDetails
    {
        public ItemDetails()
        {
            Items = new List<Item>();
        }

        public int ItemId { get; set; } // foreign key for items table

        public int Id { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int NumberAvailable { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
