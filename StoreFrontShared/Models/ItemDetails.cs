using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreFrontShared.Models
{
    public class ItemDetails : IEnumerable<ItemDetails>
    {
        //----------Default Constructor - initializes collection property-----

        public ItemDetails()
        {
            Items = new List<ItemWithDetails>();
        }

        //-----------Properties-----------------------------------------

        [Key, ForeignKey("Item")]
        public int Id { get; set; }
        public int Quantity { get; set; }
        

        //-----------Navigation Property---------------------------------

        public virtual Item Item { get; set; }

        //-----------Collection of other many-to-many object---------------

        public ICollection<ItemWithDetails> Items { get; set; }

        //----------------------------------------------------------------
        //-----------Other Methods----------------------------------------

        private List<ItemDetails> _itemDetails;

        public IEnumerator<ItemDetails> GetEnumerator()
        {
            return _itemDetails.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _itemDetails.GetEnumerator();
        }
    }
}
