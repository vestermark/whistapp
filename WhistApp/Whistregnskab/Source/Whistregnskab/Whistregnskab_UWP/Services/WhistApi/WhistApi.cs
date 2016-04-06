
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Whistregnskab_UWP.Models;
using Windows.Security.Credentials;
using Windows.UI.Popups;

namespace Whistregnskab_UWP.Services.WhistApi
{
    public class WhistApi : IWhistApi
    {
        public async Task<ObservableCollection<Pulje>> HentPuljer()
        {
            IEnumerable<Pulje> puljer = new List<Pulje>();
            if (await AuthenticateUser())
            {

                try
                {
                    puljer = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Pulje>>("HentPuljer", HttpMethod.Get, null);
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        puljer = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Pulje>>("HentPuljer", HttpMethod.Get, null);
                    }
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return new ObservableCollection<Pulje>(puljer);
        }

        public async Task<ObservableCollection<Pulje>> HentPuljer(string ejer)
        {
            IEnumerable<Pulje> puljer = new List<Pulje>();
            if (await AuthenticateUser())
            {
                try
                {
                    puljer = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Pulje>>("HentPuljer", HttpMethod.Get, new Dictionary<string, string> { {"id",ejer} });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        puljer = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Pulje>>("HentPuljer", HttpMethod.Get, new Dictionary<string, string> { { "id", ejer } });
                    }
                }
                catch(Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return new ObservableCollection<Pulje>(puljer);
        }

        public async Task<bool> OpretPuljeAsync(Pulje nyPulje)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    nyPulje.Ejer = App.passwordCredentials.UserName;
                    await App.mobileServiceClient.InvokeApiAsync("HentPuljer",JToken.FromObject(nyPulje));

                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> AuthenticateUser()
        {
            bool svar = false;
            try { App.passwordCredentials = App.passwordVault.FindAllByResource(App.serviceProvider.ToString()).FirstOrDefault(); } catch (Exception) { };
            try
            {

                if (App.passwordCredentials == null)
                {
                    App.serviceUser = await App.mobileServiceClient.LoginAsync(App.serviceProvider);
                    App.passwordCredentials = new PasswordCredential(App.serviceProvider.ToString(), App.serviceUser.UserId, App.serviceUser.MobileServiceAuthenticationToken);
                    App.passwordVault.Add(App.passwordCredentials);
                }
                else
                {
                    App.serviceUser = new MobileServiceUser(App.passwordCredentials.UserName);
                    App.passwordCredentials.RetrievePassword();
                    App.serviceUser.MobileServiceAuthenticationToken = App.passwordCredentials.Password;
                    App.mobileServiceClient.CurrentUser = App.serviceUser;
                }
                svar = true;
            }
            catch (Exception ex)
            {
                MessageDialog d = new MessageDialog(ex.Message);
                await d.ShowAsync();
            }
            return svar;
        }

        public async Task<bool> SletPuljeAsync(int PuljeId)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("HentPuljer", HttpMethod.Delete, new Dictionary<string, string> { { "Id", PuljeId.ToString() } });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> RetPuljeAsync(Pulje RetPulje)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("HentPuljer", JToken.FromObject(RetPulje), HttpMethod.Put,null);
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        await App.mobileServiceClient.InvokeApiAsync("HentPuljer", JToken.FromObject(RetPulje), HttpMethod.Put, null);
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<ObservableCollection<Runde>> HentRunder(int PuljeId)
        {
            IEnumerable<Runde> runder= null;
            if (await AuthenticateUser())
            {
                try
                {
                    runder = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Runde>>("Runde", HttpMethod.Get, new Dictionary<string, string> { { "id", PuljeId.ToString() } });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        runder = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Runde>>("Runde", HttpMethod.Get, new Dictionary<string, string> { { "id", PuljeId.ToString() } });
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return new ObservableCollection<Runde>(runder);

        }

        public async Task<bool> OpretRundeAsync(Runde nyRunde)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Runde", JToken.FromObject(nyRunde));

                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> RetRundeAsync(Runde retRunde)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Runde", JToken.FromObject(retRunde), HttpMethod.Put, null);
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        await App.mobileServiceClient.InvokeApiAsync("Runde", JToken.FromObject(retRunde), HttpMethod.Put, null);
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> SletRundeAsync(int RundeId)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Runde", HttpMethod.Delete, new Dictionary<string, string> { { "Id", RundeId.ToString() } });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<ObservableCollection<Spil>> HentSpil(int RundeId)
        {
            IEnumerable<Spil> spil = null;
            if (await AuthenticateUser())
            {
                try
                {
                    spil = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Spil>>("Spil", HttpMethod.Get, new Dictionary<string, string> { { "id", RundeId.ToString() } });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        spil = await App.mobileServiceClient.InvokeApiAsync<IEnumerable<Spil>>("Spil", HttpMethod.Get, new Dictionary<string, string> { { "id", RundeId.ToString() } });
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return new ObservableCollection<Spil>(spil);
        }

        public async Task<bool> OpretSpilAsync(Spil nytSpil)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Spil", JToken.FromObject(nytSpil));

                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> RetSpilAsync(Spil retSpil)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Spil", JToken.FromObject(retSpil), HttpMethod.Put, null);
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                        await App.mobileServiceClient.InvokeApiAsync("Spil", JToken.FromObject(retSpil), HttpMethod.Put, null);
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }

        public async Task<bool> SletSpilAsync(int SpilId)
        {
            if (await AuthenticateUser())
            {
                try
                {
                    await App.mobileServiceClient.InvokeApiAsync("Spil", HttpMethod.Delete, new Dictionary<string, string> { { "Id", SpilId.ToString() } });
                }
                catch (MobileServiceInvalidOperationException ex)
                {
                    if (ex.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        App.passwordVault.Remove(App.passwordCredentials);
                        await AuthenticateUser();
                    }
                }
                catch (Exception ex)
                {
                    string mess = ex.ToString();
                }
            }
            else
            {
                MessageDialog dlg = new MessageDialog("Fejl ved authentication!");
                await dlg.ShowAsync();
            }
            return true;
        }
    }
}
