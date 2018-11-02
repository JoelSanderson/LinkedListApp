using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LinkedLists.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LinkedLists
{
    public partial class App : Application
    {
        public static object Database { get; internal set; }

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
