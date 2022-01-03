using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;

using ReactiveUI;

using RxMauiSamples.ViewModels;
using RxMauiSamples.Views;

using Splat;

using Application = Microsoft.Maui.Controls.Application;

namespace RxMauiSamples
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new MainPage();

			Locator.CurrentMutable.Register<IViewFor<AboutViewModel>>(() => new AboutPage());

			MainPage = new AppShellViewModel().CreateShell();

		}
	}
}
