using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Whistregnskab_UWP.Models;
using Whistregnskab_UWP.Services.WhistApi;
using Whistregnskab_UWP.Views;
using Windows.UI.Popups;
using Windows.UI.Xaml.Navigation;

namespace Whistregnskab_UWP.ViewModels
{
    public class RundePageViewModel: ViewModelBase
    {
        private IWhistApi _whistApi;

        public RundePageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private RundeHeader _Runde;
        public RundeHeader Runde { get { return _Runde; } set { Set(ref _Runde, value); } }

        private ObservableCollection<Spil> _Spil;
        public ObservableCollection<Spil> Spil { get { return _Spil; } set { Set(ref _Spil, value); } }

        private Spil _SelectedSpil;
        public Spil SelectedSpil { get { return _SelectedSpil; } set { Set(ref _SelectedSpil, value); } }


        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
            }

            Runde = (RundeHeader)parameter;
            Spil = await _whistApi.HentSpil(Runde.RundeId);
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

        public void Ret()
        {
            NavigationService.Navigate(typeof(RetRundePage), Runde);
        }

        public void NytSpil()
        {
            App.RundeH = Runde;
            NavigationService.Navigate(typeof(SpilPage));
        }

        public async Task SpilSelected()
        {
            App.RundeH = Runde;
            App.Spil = SelectedSpil;
            NavigationService.Navigate(typeof(SpilPage), SelectedSpil);
            await Task.CompletedTask;
        }

        public async Task Slet()
        {
            MessageDialog dialog = new MessageDialog("Ønsker du at slette denne runde?");

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Ja") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Nej") { Id = 1 });

            dialog.DefaultCommandIndex = 1;
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();

            if (((int)result.Id)==0)
            {
                dialog = new MessageDialog("Er du sikker?");

                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Ja") { Id = 0 });
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Nej") { Id = 1 });

                dialog.DefaultCommandIndex = 1;
                dialog.CancelCommandIndex = 1;

                result = await dialog.ShowAsync();

                if (((int)result.Id) == 0)
                {
                    await _whistApi.SletRundeAsync(Runde.RundeId);
                    NavigationService.Navigate(typeof(PuljePage), App.Pulje);
                }

            }
        }

    }
}
