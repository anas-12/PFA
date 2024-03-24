using System;
using UIProject.Services;
using UIProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new NavigationPage (new LoginPage());
            //MainPage = new MyFlyoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
