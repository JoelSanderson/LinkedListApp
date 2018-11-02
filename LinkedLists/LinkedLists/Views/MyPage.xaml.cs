using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LinkedLists.Models;
using LinkedLists.ViewModels;

namespace LinkedLists.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ProfilePage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ProfilePage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}