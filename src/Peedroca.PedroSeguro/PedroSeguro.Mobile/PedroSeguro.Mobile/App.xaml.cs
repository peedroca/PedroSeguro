using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using PedroSeguro.Domain.Enums;
using PedroSeguro.Domain.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedroSeguro.Mobile
{
    public partial class App : Application
    {
        public App(IAppNavigation appNavigation)
        {
            InitializeComponent();

            MainPage = new NavigationPage((TabbedPage)appNavigation.GetPage(EPage.MainTabbedPage));
        }

        protected override void OnStart()
        {
            AppCenter.Start("2d5ca795-d721-4ac2-a663-8b819f7a547d",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
