using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Template10.Common;
using Template10.Controls;
using Template10.Services.NavigationService;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Whistregnskab_UWP.Views
{
    public sealed partial class Shell : Page
    {
        public static Shell Instance { get; set; }
        public static HamburgerMenu HamburgerMenu { get { return Instance.MyHamburgerMenu; } }

        public Shell()
        {
            Instance = this;
            InitializeComponent();
        }

        public Shell(INavigationService navigationService) : this()
        {
            SetNavigationService(navigationService);
        }

        public void SetNavigationService(INavigationService navigationService)
        {
            MyHamburgerMenu.NavigationService = navigationService;
        }

        private void HamburgerButtonInfo_Tapped(object sender, RoutedEventArgs e)
        {
            if (App.passwordCredentials != null)
            {
                App.passwordVault.Remove(App.passwordCredentials);
                App.passwordCredentials = null;
                MessageDialog dlg = new MessageDialog("Bruger fjernet");
                dlg.ShowAsync();
            }
        }
    }
}

