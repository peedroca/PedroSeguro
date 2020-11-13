using PedroSeguro.BaseComponents;
using PedroSeguro.PasswordManage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedroSeguro.PasswordManage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordsPage : BaseContentPage
    {
        public PasswordsPage()
            : base(typeof(ManagePasswordViewModel))
        {
            InitializeComponent();
        }
    }
}