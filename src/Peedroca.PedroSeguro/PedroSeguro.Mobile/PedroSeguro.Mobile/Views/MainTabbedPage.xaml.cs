using PedroSeguro.BaseComponents;
using PedroSeguro.Domain.Enums;
using PedroSeguro.Domain.Interfaces;
using PedroSeguro.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedroSeguro.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : BaseTabbedPage
    {
        public MainTabbedPage(IAppNavigation appNavigation)
            : base(typeof(MainViewModel))
        {
            InitializeComponent();
            this.Children.Add((Page)appNavigation.GetPage(EPage.GenPassWordPage));
            this.Children.Add((Page)appNavigation.GetPage(EPage.PasswordsPage));
        }
    }
}