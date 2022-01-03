using System;
using System.Reactive.Disposables;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

using ReactiveUI;
using ReactiveUI.Maui;

using RxMauiSamples.ViewModels;

using Splat;

namespace RxMauiSamples.Views
{
	public partial class AppShell : ReactiveFlyoutPage<AppShellViewModel>
	{
		public AppShell()
		{
			InitializeComponent();
			ViewModel = Locator.Current.GetService<AppShellViewModel>();
			this.WhenActivated(d =>
			{
				this.WhenAnyValue(x => x.ViewModel).BindTo(this, x => x.BindingContext).DisposeWith(d);
			});
		}
    }
}
