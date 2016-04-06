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
using Windows.UI.Popups;
using Windows.UI.Xaml.Navigation;

namespace Whistregnskab_UWP.ViewModels
{
    public class SpilPageViewModel : ViewModelBase
    {
        private IWhistApi _whistApi;

        public SpilPageViewModel(IWhistApi whistAPI)
        {
            this._whistApi = whistAPI;
        }

        private Pulje _Pulje;
        public Pulje Pulje
        {
            get { return _Pulje; }
            set { Set(ref _Pulje, value); }
        }

        private int _Melder;
        public int Melder
        {
            get { return _Melder; }
            set { Set(ref _Melder, value); }
        }

        private int _Makker;
        public int Makker
        {
            get { return _Makker; }
            set { Set(ref _Makker, value); }
        }

        private int _Melding;
        public int Melding
        {
            get { return _Melding; }
            set { Set(ref _Melding, value); }
        }

        private int _Skæve;
        public int Skæve
        {
            get { return _Skæve; }
            set { Set(ref _Skæve, value); }
        }


        private int _Stik;
        public int Stik
        {
            get { return _Stik; }
            set { Set(ref _Stik, value); }
        }



        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
            }
            Pulje = App.Pulje;
            if (App.Spil != null)
            {
                Melder = App.Spil.Melder;
                Makker = App.Spil.Makker;
                Melding = BeregnMelding(App.Spil.Melding);
                Skæve = BeregnSkæve(App.Spil.Melding);
                Stik = App.Spil.Stik;
            }
            else
            {
                Makker = 4;
                Melding = 3;
            }
            await Task.CompletedTask;
        }

        private int BeregnMelding(int Melding)
        {
            int melding = 0;
            string skæve = "";
            switch (Melding)
            {
                case -1:
                    melding = 0;
                    break;
                case 0:
                    melding = 1;
                    break;
                case 1:
                    melding = 2;
                    break;
                default:
                    int korrigeretMelding = Melding;
                    if (Melding > 9)
                    {
                        if (Melding > 10 && Melding < 20) { skæve = "halve"; korrigeretMelding = korrigeretMelding - 10; }
                        if (Melding > 20 && Melding < 30) { skæve = "vip"; korrigeretMelding = korrigeretMelding - 20; }
                        if (Melding > 30 && Melding < 40) { skæve = "sans"; korrigeretMelding = korrigeretMelding - 30; }
                        if (Melding > 40 && Melding < 50) { skæve = "gode"; korrigeretMelding = korrigeretMelding - 40; }
                    }
                    melding = (korrigeretMelding);
                    break;
            }
            return melding;
        }

        private int BeregnSkæve(int Melding)
        {
            int melding = 0;
            string skæve = "";
            switch (Melding)
            {
                case -1:
                    melding = 0;
                    break;
                case 0:
                    melding = 1;
                    break;
                case 1:
                    melding = 2;
                    break;
                default:
                    int korrigeretMelding = Melding;
                    if (Melding > 9)
                    {
                        if (Melding > 10 && Melding < 20) { skæve = "halve"; korrigeretMelding = korrigeretMelding - 10; }
                        if (Melding > 20 && Melding < 30) { skæve = "vip"; korrigeretMelding = korrigeretMelding - 20; }
                        if (Melding > 30 && Melding < 40) { skæve = "sans"; korrigeretMelding = korrigeretMelding - 30; }
                        if (Melding > 40 && Melding < 50) { skæve = "gode"; korrigeretMelding = korrigeretMelding - 40; }
                    }
                    melding = (korrigeretMelding);
                    break;
            }
            switch (skæve)
            {
                case "halve":
                    melding = 1;
                    break;
                case "vip":
                    melding = 2;
                    break;
                case "sans":
                    melding = 3;
                    break;
                case "gode":
                    melding = 4;
                    break;
                default:
                    melding = 0;
                    break;
            }
            return melding;
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
            if (App.Spil == null)
            {
                var spil = new Spil();
                spil.Makker = Makker;
                spil.Stik = Stik;
                spil.Melder = Melder;
                BeregnMeldingFraIndtastning(spil, Melding, Skæve);
                await _whistApi.OpretSpilAsync(spil);
                NavigationService.Navigate(typeof(RundePage), App.RundeH);
            }
            else
            {
                var spil = App.Spil;
                spil.Makker = Makker;
                spil.Stik = Stik;
                spil.Melder = Melder;
                BeregnMeldingFraIndtastning(spil, Melding, Skæve);
                await _whistApi.RetSpilAsync(spil);
                NavigationService.Navigate(typeof(RundePage), App.RundeH);
            }
        }

        private void BeregnMeldingFraIndtastning(Spil spil, int Melding, int Skæve)
        {
            if (Skæve > 0 && Melding > 1)
            {
                Melding += Skæve * 10;
            }
            int[] point = WhistCalc.BeregnPoint(spil.Melder, Melding, spil.Stik, spil.Makker);
            spil.Point1 = point[0];
            spil.Point2 = point[1];
            spil.Point3 = point[2];
            spil.Point4 = point[3];
        }

        public async Task Slet()
        {
            MessageDialog dialog = new MessageDialog("Ønsker du at slette dette spil?");

            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Ja") { Id = 0 });
            dialog.Commands.Add(new Windows.UI.Popups.UICommand("Nej") { Id = 1 });

            dialog.DefaultCommandIndex = 1;
            dialog.CancelCommandIndex = 1;

            var result = await dialog.ShowAsync();

            if (((int)result.Id) == 0)
            {
                dialog = new MessageDialog("Er du sikker?");

                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Ja") { Id = 0 });
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Nej") { Id = 1 });

                dialog.DefaultCommandIndex = 1;
                dialog.CancelCommandIndex = 1;

                result = await dialog.ShowAsync();

                if (((int)result.Id) == 0)
                {
                    await _whistApi.SletSpilAsync(App.Spil.SpilId);
                    NavigationService.Navigate(typeof(RundePage), App.Runde);
                }
            }
        }
    }
}
