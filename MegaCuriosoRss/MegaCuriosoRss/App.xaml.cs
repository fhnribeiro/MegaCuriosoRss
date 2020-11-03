using System;
using View.MegaCuriosoRss;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MegaCuriosoRss
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
