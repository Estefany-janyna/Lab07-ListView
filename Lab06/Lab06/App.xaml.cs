using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ///MainPage = new MainPage();
            ///permite que en la app 
            MainPage = new NavigationPage(new MainPage());
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
