using Template10.Mvvm;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Whistregnskab_UWP.Services.WhistApi;
using System.Collections.ObjectModel;
using Whistregnskab_UWP.Models;
using Whistregnskab_UWP.Views;

namespace Whistregnskab_UWP.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private IWhistApi _whistApi;

        public MainPageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private ObservableCollection<Pulje> _Puljer;
        public ObservableCollection<Pulje> Puljer { get { return _Puljer; } set { Set(ref _Puljer, value); } }

        private Pulje _SelectedPulje;
        public Pulje SelectedPulje { get { return _SelectedPulje; } set { Set(ref _SelectedPulje, value); } }


        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
            }

            await FindBrugerIVaultAsync();
            Puljer = await _whistApi.HentPuljer(App.passwordCredentials.UserName);
            if (Puljer.Count==0)
            {
                NavigationService.Navigate(typeof(RetPuljePage));
            }
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

        public async Task PuljeSelected()
        {
            App.Pulje = SelectedPulje;
            NavigationService.Navigate(typeof(PuljePage), SelectedPulje);
            await Task.CompletedTask;
        }
        private async Task<bool> FindBrugerIVaultAsync()
        {
            bool svar = false;
            try { App.passwordCredentials = App.passwordVault.FindAllByResource(App.serviceProvider.ToString()).FirstOrDefault(); } catch { };
            if (App.passwordCredentials == null)
            {
                await _whistApi.AuthenticateUser();
                svar = true;
            }
            else
            {
                svar = true;
            }
            return svar;
        }

        public void Opret()
        {
            NavigationService.Navigate(typeof(RetPuljePage));
        }
    }
}

