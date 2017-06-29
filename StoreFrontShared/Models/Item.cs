using System.ComponentModel.DataAnnotations;

namespace StoreFrontShared.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public ItemDetails ItemDetails { get; set; }
        //public int NumberAvailable { get; set; }
    }
}
