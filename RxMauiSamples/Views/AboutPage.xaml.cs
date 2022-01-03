using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

using ReactiveUI;
using ReactiveUI.Maui;

using RxMauiSamples.ViewModels;

namespace RxMauiSamples.Views
{
	public partial class AboutPage : ReactiveContentPage<AboutViewModel>
	{
		public AboutPage()
		{
			InitializeComponent();
		}
	}
}
