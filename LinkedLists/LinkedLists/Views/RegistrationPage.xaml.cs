using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace LinkedLists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void registerClicked(object sender, EventArgs e)
        {
            string uname = usernameEntry.Text;
            string pass = passEntry.Text;
            //var result = await DisplayAlert("Success", "Registered!", null,"OK");
            //if (result)
            //{
            //    var newPage = new MainPage();
            //    await Navigation.PushAsync(newPage);
            //} else if (uname == null || pass == null)
            //{
            //    await DisplayAlert("Alert ", "Please enter a username and password", "OK");
            //}

            if (uname != null && pass != null)
            {
                var result = await DisplayAlert("Success", "Registered!", null, "OK");
                if (result)
                {
                    //var newPage = new ();
                    //await Navigation.PushAsync(newPage);
                }
            }
            else if (uname == null || pass == null)
            {
                await DisplayAlert("Alert ", "Please enter a username and password", "OK");
            }

        }
    }
}
