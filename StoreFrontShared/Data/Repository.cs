using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StoreFrontShared.Models;

namespace StoreFrontShared.Data
{
    public class Repository
    {
        private Context _context = null;

        public Repository(Context context)
        {
            _context = context;
        }

        public List<Item> GetItems()
        {
            return _context.Items
                .Include(i => i.ItemDetailsCollection.Select(id => id.ItemDetails))
                .ToList();
        }

        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }
    }
}
