using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using PedroSeguro.ApplicationObjects;
using PedroSeguro.Domain.Enums;
using PedroSeguro.Domain.Interfaces;
using PedroSeguro.Mobile.Utils;
using PedroSeguro.Mobile.ViewModels;
using PedroSeguro.Mobile.Views;
using PedroSeguro.PasswordManage.ViewModels;
using PedroSeguro.PasswordManage.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedroSeguro.Mobile.Droid
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder cb)
        {
            base.RegisterDependencies(cb);

            // Registro das ViewModels

            cb.RegisterType<MainViewModel>().SingleInstance();
            cb.RegisterType<ManagePasswordViewModel>().SingleInstance();
            cb.RegisterType<GeneratePasswordViewModel>().SingleInstance();

            // Registro das classes implementadas

            cb.RegisterInstance<IAppNavigation>(new AppNavigation()).SingleInstance();

            // Registro das páginas

            cb.RegisterType<MainTabbedPage>().Keyed<IPage>(EPage.MainTabbedPage);
            cb.RegisterType<GenPassWordPage>().Keyed<IPage>(EPage.GenPassWordPage);
            cb.RegisterType<PasswordsPage>().Keyed<IPage>(EPage.PasswordsPage);
        }
    }
}