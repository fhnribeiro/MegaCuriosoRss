using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;
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
            string androidAppSecret = "7692e508-44c4-4828-b516-fb651ccbf686";
            string iosAppSecret = "c6530b6a-dec2-4a99-8e95-c7531b9bec22";
            AppCenter.Start($"android={androidAppSecret};ios={iosAppSecret}", typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
