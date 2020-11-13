using Autofac;
using PedroSeguro.ApplicationObjects;
using PedroSeguro.Domain.Enums;
using PedroSeguro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PedroSeguro.Mobile.Utils
{
    public class AppNavigation : IAppNavigation
    {
        public EPage CurrentPageKey { get; private set; }

        public object GetPage(EPage ePage)
        {
            return AppContainer.Container.ResolveKeyed<IPage>(ePage);
        }

        public void OpenPage(EPage ePage)
        {
            var page = (Page)AppContainer.Container.ResolveKeyed<IPage>(ePage);
            CurrentPageKey = ePage;
            App.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
