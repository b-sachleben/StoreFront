using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontShared.Models
{
    public class ItemWithDetails
    {
        //------------Properties-----------------------------------------------

        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; } // Foreign Key for Item
        public int ItemDetailsId { get; set; } // Foreign Key for ItemDetails

        //------------Navigation Properties------------------------------------

        public Item Item { get; set; }
        public ItemDetails ItemDetails { get; set; }
    }
}
