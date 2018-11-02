using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LinkedLists.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }


        private async void loginClicked(object sender, EventArgs e)
        {
            //Get the value of both entries.
            string name = userEntry.Text;
            string pass = entryPassword.Text;

            //Show value of User
            if (name == "admin" && pass == "admin")
            {
                await Navigation.PushAsync(new MainPage());
                //await DisplayAlert("Hello, ", name, "!");
            }
            else if (name == null && pass == null)
            {
                await DisplayAlert("Alert ", "Please enter your username and password", "OK");
            }

            else if (name != "admin" && pass != "admin")
            {
                await DisplayAlert("Alert ", "Incorrect Credentials", "OK");
            }
        }
    }
}
