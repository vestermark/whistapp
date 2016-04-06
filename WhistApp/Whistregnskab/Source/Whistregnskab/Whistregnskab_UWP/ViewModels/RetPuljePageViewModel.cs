using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Whistregnskab_UWP.Models;
using Whistregnskab_UWP.Services.WhistApi;
using Whistregnskab_UWP.Views;
using Windows.UI.Xaml.Navigation;

namespace Whistregnskab_UWP.ViewModels
{
    public class RetPuljePageViewModel : ViewModelBase
    {
        private IWhistApi _whistApi;

        public RetPuljePageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private Pulje _Pulje;
        public Pulje Pulje
        {
            get { return _Pulje; }
            set { Set(ref _Pulje, value); }
        }

        private string _TopTekst;
        public string TopTekst
        {
            get { return _TopTekst; }
            set { Set(ref _TopTekst, value); }
        }

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
            }
            if (parameter!=null)
            {
                Pulje = (Pulje)parameter;
                TopTekst = "Ret pulje";
            }
            else
            {
                Pulje = new Pulje() { Oprettelsesdato = DateTime.Now };
                TopTekst = "Opret ny pulje";
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                //suspensionState[nameof(Value)] = Value;
            }
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public async Task Gem()
        {
            bool svar = false;
            if (Pulje.PuljeId==0)
            {
                svar = await _whistApi.OpretPuljeAsync(Pulje);
            }
            else
            {
                svar = await _whistApi.RetPuljeAsync(Pulje);
            }
            if (svar) NavigationService.Navigate(typeof(MainPage));
        }


    }
}
