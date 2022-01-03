using Microsoft.Maui.Controls;
using ReactiveUI;
using ReactiveUI.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RxMauiSamples
{
    public class ReactiveFlyoutPage<TViewModel> : FlyoutPage, IViewFor<TViewModel>, IViewFor, IActivatableView where TViewModel : class
    {
        /// <summary>
        /// The view model bindable property.
        /// </summary>
        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(TViewModel), typeof(ReactiveFlyoutPage<TViewModel>), null, BindingMode.OneWay, null, OnViewModelChanged);

        /// <summary>
        /// Gets or sets the ViewModel to display.
        /// </summary>
        public TViewModel ViewModel
        {
            get => (TViewModel)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TViewModel)value;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            ViewModel = (base.BindingContext as TViewModel);
        }

        private static void OnViewModelChanged(BindableObject bindableObject, object oldValue, object newValue)
        {
            bindableObject.BindingContext = newValue;
        }

    }
}
