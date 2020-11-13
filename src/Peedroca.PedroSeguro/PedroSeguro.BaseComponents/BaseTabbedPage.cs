using Autofac;
using PedroSeguro.ApplicationObjects;
using PedroSeguro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PedroSeguro.BaseComponents
{
    public class BaseTabbedPage : TabbedPage, IPage
    {
        readonly object _viewModel;
        public object ViewModel { get { return _viewModel; } }

        public BaseTabbedPage(Type viewModel)
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                _viewModel = AppContainer.Container.Resolve(viewModel);
            }

            BindingContext = _viewModel;
        }
    }
}
