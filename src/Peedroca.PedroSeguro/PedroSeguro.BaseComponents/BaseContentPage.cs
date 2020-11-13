using Autofac;
using Microsoft.AppCenter.Analytics;
using PedroSeguro.ApplicationObjects;
using PedroSeguro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PedroSeguro.BaseComponents
{
    public class BaseContentPage : ContentPage, IPage
    {
        readonly object _viewModel;
        public object ViewModel { get { return _viewModel; } }

        public BaseContentPage(Type viewModel)
        {
            using (var scope = AppContainer.Container.BeginLifetimeScope())
            {
                _viewModel = AppContainer.Container.Resolve(viewModel);
            }

            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Analytics.TrackEvent($"{GetType().Name} Appeared");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            Analytics.TrackEvent($"{GetType().Name} Disappeared");
        }
    }
}
