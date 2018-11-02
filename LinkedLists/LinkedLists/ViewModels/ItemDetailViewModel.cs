using System;

using LinkedLists.Models;

namespace LinkedLists.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.ListTitle;
            Item = item;
        }
    }
}
