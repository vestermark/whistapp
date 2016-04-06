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
    public class RetRundePageViewModel : ViewModelBase
    {
        private IWhistApi _whistApi;

        public RetRundePageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private Runde _Runde;
        public Runde Runde
        {
            get { return _Runde; }
            set { Set(ref _Runde, value); }
        }

        private RundeHeader _RundeH;
        public RundeHeader RundeH
        {
            get { return _RundeH; }
            set { Set(ref _RundeH, value); }
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
            RundeH = (RundeHeader)parameter;
            if (RundeH.RundeId>0)
            {
                TopTekst = "Ret runde";
                Runde = new Runde();
                Runde.RundeId = RundeH.RundeId;
                Runde.Sted = RundeH.Sted;
                Runde.Dato = RundeH.Dato;
                Runde.Bem = RundeH.Bem;
                Runde.PuljeId = RundeH.PuljeId;
                Runde.Point1 = RundeH.Point1;
                Runde.Point2 = RundeH.Point2;
                Runde.Point3 = RundeH.Point3;
                Runde.Point4 = RundeH.Point4;
            }
            else
            {
                Runde = new Runde() { Dato = DateTime.Now };
                Runde.PuljeId = RundeH.PuljeId;
                TopTekst = "Opret ny runde";
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
            if (Runde.RundeId==0)
            {
                svar = await _whistApi.OpretRundeAsync(Runde);
                if (svar)
                {
                    NavigationService.Navigate(typeof(PuljePage),App.Pulje);
                }
            }
            else
            {
                svar = await _whistApi.RetRundeAsync(Runde);
                if (svar)
                {
                    RundeH.Sted = Runde.Sted;
                    RundeH.Dato = Runde.Dato;
                    RundeH.Bem = Runde.Bem;
                    NavigationService.Navigate(typeof(RundePage), RundeH);
                }
            }
        }
    }
}
