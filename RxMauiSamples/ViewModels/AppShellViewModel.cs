using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

using RxMauiSamples.Views;

using Splat;

namespace RxMauiSamples.ViewModels
{
    public class AppShellViewModel : ReactiveObject, IScreen
    {
        public AppShellViewModel()
        {
            Title = "RxMauiApp";
            Router = new();
            Message = "Hello";
            RegisterTypes();
            Router.NavigateAndReset.Execute(new AboutViewModel()).Subscribe();
        }

        [Reactive] public string Message { get; set; }
        public RoutingState Router { get; }
        [Reactive] public bool IsBusy { get; set; }
        [Reactive] public string Title { get; set; } = "RxMauiApp";
        private void RegisterTypes()
        {
            Locator.CurrentMutable.RegisterConstant<AppShellViewModel>(this);
            Locator.CurrentMutable.RegisterConstant<IScreen>(this);
            //Locator.CurrentMutable.RegisterViewsForViewModels(GetType().Assembly);
        }

        public Page CreateShell()
        {
            return new AppShell();
        }
    }
}
