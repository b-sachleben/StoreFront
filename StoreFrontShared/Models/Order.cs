using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontShared.Models
{
    public class Order
    {
        public Order()
        {
            Items = new List<Item>();
            TotalPrice = 0;
        }

        public int Id { get; set; }
        public string Client { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; private set; }
        public DateTime Date { get; set; }
        public bool HasShipped { get; set; }

        public ICollection<Item> Items { get; set; }

        //public ICollection<object> ItemQuantity = new List<object>(); //creates an array of items with quantity to calculate total price with

        //public void AddItem(Item item, int quantity)
        //{
        //    foreach(var entry in Items)
        //    {
        //        this.ItemQuantity.Add(item);
        //        this.ItemQuantity.Add(quantity);
        //    }
        //}

        public void CalculateTotal()
        {
            decimal runningTotal = 0;

            foreach(Item item in Items)
            {
                var IndividualItemTotal = (this.Item.ItemDetails.Price) * (this.Item.ItemDetails.Quantity);
                runningTotal += IndividualItemTotal;
            }

            decimal roundedRunningTotal = Math.Round(runningTotal, 2, MidpointRounding.AwayFromZero);

            TotalPrice = roundedRunningTotal;
        }
    }
}
