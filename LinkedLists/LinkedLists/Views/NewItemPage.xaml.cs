using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LinkedLists.Models;
using LinkedLists.Database;


namespace LinkedLists.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }
        
        public NewItemPage()
        {
            InitializeComponent();

            object selectedType = listType.SelectedItem;
            object selectedCategory = listCategory.SelectedItem;
            object selectedPrivacy = listPrivacy.SelectedItem;

            string title = listTitle.Text;
            //ListType type = (ListType)Enum.Parse(typeof(ListType), selectedType.ToString());
            ListType type = ListType.Checklist;
            //ListCategory category = (ListCategory)Enum.Parse(typeof(ListCategory), selectedCategory.ToString());
            ListCategory category = ListCategory.Entertainment;
            //ListPrivacy privacy = (ListPrivacy)Enum.Parse(typeof(ListPrivacy), selectedPrivacy.ToString());
            ListPrivacy privacy = ListPrivacy.Private;
            string data = listData.Text;

            Item = new Item(Guid.NewGuid().ToString(), title, type, category, privacy, data, 0, 0);

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (NewItemPage)BindingContext;
            await ListDatabase.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (NewItemPage)BindingContext;
            await ListDatabase.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    

    }
}
