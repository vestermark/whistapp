using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whistregnskab_UWP.Services.WhistApi;

namespace Whistregnskab_UWP.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IWhistApi,WhistApi>();
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<PuljePageViewModel>();
            SimpleIoc.Default.Register<RundePageViewModel>();
            SimpleIoc.Default.Register<RetPuljePageViewModel>();
            SimpleIoc.Default.Register<RetRundePageViewModel>();
            SimpleIoc.Default.Register<SpilPageViewModel>();
        }
        public MainPageViewModel MainPageViewModel => ServiceLocator.Current.GetInstance<MainPageViewModel>();
        public PuljePageViewModel PuljePageViewModel => ServiceLocator.Current.GetInstance<PuljePageViewModel>();
        public RundePageViewModel RundePageViewModel => ServiceLocator.Current.GetInstance<RundePageViewModel>();
        public RetPuljePageViewModel RetPuljePageViewModel => ServiceLocator.Current.GetInstance<RetPuljePageViewModel>();
        public RetRundePageViewModel RetRundePageViewModel => ServiceLocator.Current.GetInstance<RetRundePageViewModel>();
        public SpilPageViewModel SpilPageViewModel => ServiceLocator.Current.GetInstance<SpilPageViewModel>();
    }
}













