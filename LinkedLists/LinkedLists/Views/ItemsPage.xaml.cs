using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LinkedLists.Models;
using LinkedLists.Views;
using LinkedLists.ViewModels;

namespace LinkedLists.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item(Guid.NewGuid().ToString(), "Title", ListType.BestOf, ListCategory.Entertainment, ListPrivacy.Private, "", 0, 0);

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}
