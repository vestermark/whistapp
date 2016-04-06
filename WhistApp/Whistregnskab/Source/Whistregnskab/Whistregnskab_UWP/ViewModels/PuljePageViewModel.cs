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
    public class PuljePageViewModel: ViewModelBase
    {
        private IWhistApi _whistApi;

        public PuljePageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private Pulje _Pulje;
        public Pulje Pulje { get { return _Pulje; } set { Set(ref _Pulje, value); } }

        private ObservableCollection<Runde> _Runder;
        public ObservableCollection<Runde> Runder { get { return _Runder; } set { Set(ref _Runder, value); } }

        private Runde _SelectedRunde;
        public Runde SelectedRunde { get { return _SelectedRunde; } set { Set(ref _SelectedRunde, value); } }



        public async Task RundeSelected()
        {
            App.Runde = SelectedRunde;
            var RundeH = new RundeHeader();
            RundeH.RundeId = SelectedRunde.RundeId;
            RundeH.Dato = SelectedRunde.Dato;
            RundeH.Sted = SelectedRunde.Sted;
            RundeH.PuljeId = SelectedRunde.PuljeId;
            RundeH.Bem = SelectedRunde.Bem;
            RundeH.Point1 = SelectedRunde.Point1;
            RundeH.Point2 = SelectedRunde.Point2;
            RundeH.Point3 = SelectedRunde.Point3;
            RundeH.Point4 = SelectedRunde.Point4;
            RundeH.Spiller1 = Pulje.Spiller1;
            RundeH.Spiller2 = Pulje.Spiller2;
            RundeH.Spiller3 = Pulje.Spiller3;
            RundeH.Spiller4 = Pulje.Spiller4;
            NavigationService.Navigate(typeof(RundePage), RundeH);
            await Task.CompletedTask;
        }


        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
            }

            Pulje = (Pulje)parameter;
            Runder = await _whistApi.HentRunder(Pulje.PuljeId);
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
            NavigationService.Navigate(typeof(RetPuljePage), Pulje);
        }

        public void NewRunde()
        {
            App.Pulje = Pulje;
            RundeHeader runde = new RundeHeader();
            runde.PuljeId = Pulje.PuljeId;
            NavigationService.Navigate(typeof(RetRundePage), runde);
        }


        public async Task Slet()
        {
            MessageDialog dialog = new MessageDialog("Ønsker du at slette denne pulje?");

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
                    await _whistApi.SletPuljeAsync(Pulje.PuljeId);
                    NavigationService.Navigate(typeof(MainPage));
                }

            }
        }

    }
}
