using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

using Splat;

namespace RxMauiSamples.ViewModels
{
    public class AboutViewModel : ReactiveObject, IRoutableViewModel
    {
        public AboutViewModel()
        {
            UrlPathSegment = "关于";
            HostScreen = Locator.Current.GetService<IScreen>();
        }

        public string UrlPathSegment { get; }
        public IScreen HostScreen { get; }
    }
}
