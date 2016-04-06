

using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Whistregnskab_UWP.Models;

namespace Whistregnskab_UWP.Services.WhistApi
{
    public interface IWhistApi
    {
        Task<ObservableCollection<Pulje>> HentPuljer();
        Task<ObservableCollection<Pulje>> HentPuljer(string ejer);
        Task<bool> OpretPuljeAsync(Pulje nyPulje);
        Task<bool> RetPuljeAsync(Pulje nyPulje);
        Task<bool> SletPuljeAsync(int PuljeId);


        Task<ObservableCollection<Runde>> HentRunder(int PuljeId);
        Task<bool> OpretRundeAsync(Runde nyRunde);
        Task<bool> RetRundeAsync(Runde retRunde);
        Task<bool> SletRundeAsync(int RundeId);

        Task<ObservableCollection<Spil>> HentSpil(int RundeId);
        Task<bool> OpretSpilAsync(Spil nytSpil);
        Task<bool> RetSpilAsync(Spil retSpil);
        Task<bool> SletSpilAsync(int SpilId);
        

        Task<bool> AuthenticateUser();

    }
}








