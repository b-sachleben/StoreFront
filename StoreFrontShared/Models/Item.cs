using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreFrontShared.Models
{
    public class Item : IEnumerable<Item>
    {
        //----------Default Constructor - initializes collection property-----

        public Item()
        {
            ItemDetailsCollection = new List<ItemWithDetails>();
        }

        //-----------Properties-----------------------------------------

        public int Id { get; set; }
        //public int ItemDetailsId { get; set; } // Foreign key for ItemDetails table
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int NumberAvailable { get; set; }

        //-----------Navigation Property-----------------------------------

        public virtual ItemDetails ItemDetails { get; set; }

        //-----------Collection of other many-to-many object---------------

        public ICollection<ItemWithDetails> ItemDetailsCollection { get; set; }

        //----------------------------------------------------------------
        //-----------Other Methods----------------------------------------

        public void AddDetails(Item item, ItemDetails itemDetails)
        {
            ItemDetailsCollection.Add(new ItemWithDetails()
            {
                Item = item,
                ItemDetails = itemDetails
            });
        }

        private List<Item> _item;

        public IEnumerator<Item> GetEnumerator()
        {
            return _item.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _item.GetEnumerator();
        }
    }
}
