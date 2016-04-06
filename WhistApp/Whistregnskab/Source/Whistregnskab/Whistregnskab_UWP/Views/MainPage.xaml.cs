
using Whistregnskab_UWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Whistregnskab_UWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }
        MainPageViewModel ViewModel => this.DataContext as MainPageViewModel;
    }
}
