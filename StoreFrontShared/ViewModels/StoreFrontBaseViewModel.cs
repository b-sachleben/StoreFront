using StoreFrontShared.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFrontShared.ViewModels
{
    public abstract class StoreFrontBaseViewModel : IEnumerable<StoreFrontBaseViewModel>
    {
        public Item Item { get; set; }
        public ItemDetails ItemDetails { get; set; }

        private List<StoreFrontBaseViewModel> _storeFrontBaseViewModel;

        public IEnumerator<StoreFrontBaseViewModel> GetEnumerator()
        {
            return _storeFrontBaseViewModel.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _storeFrontBaseViewModel.GetEnumerator();
        }
    }
}
