using Windows.UI.Xaml;
using System.Threading.Tasks;
using Whistregnskab_UWP.Services.SettingsServices;
using Windows.ApplicationModel.Activation;
using Template10.Controls;
using Template10.Common;
using Windows.Security.Credentials;
using Microsoft.WindowsAzure.MobileServices;
using Whistregnskab_UWP.Models;
using NotificationsExtensions.Tiles;

namespace Whistregnskab_UWP
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    sealed partial class App : Template10.Common.BootStrapper
    {

        public static PasswordVault passwordVault;
        public static PasswordCredential passwordCredentials;
        public static MobileServiceClient mobileServiceClient;
        public static MobileServiceAuthenticationProvider serviceProvider;
        public static MobileServiceUser serviceUser;

        public static Pulje Pulje;
        public static Runde Runde;
        public static RundeHeader RundeH;
        public static Spil Spil;

        static App()
        {
            passwordVault = new PasswordVault();
            passwordCredentials = null;
            mobileServiceClient = new MobileServiceClient("https://morewhist.azurewebsites.net/");
            serviceProvider = MobileServiceAuthenticationProvider.MicrosoftAccount;
            serviceUser = null;
        }

        public App()
        {
            InitializeComponent();
            SplashFactory = (e) => new Views.Splash(e);
        }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            // content may already be shell when resuming
            if ((Window.Current.Content as ModalDialog) == null)
            {
                // setup hamburger shell inside a modal dialog
                var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);
                Window.Current.Content = new ModalDialog
                {
                    DisableBackButtonWhenModal = true,
                    Content = new Views.Shell(nav),
                    ModalContent = new Views.Busy(),
                };
            }
            await Task.CompletedTask;
            var tc = new TileContent()

            {

                Visual = new TileVisual()

                {

                    //

                    TileWide = new TileBinding()
                    {
                        Branding = TileBranding.NameAndLogo,
                        Content = new TileBindingContentAdaptive()
                        {
                            Children =
                        {
                            CreateGroup(
                                userOne: "Lisbeth",
                                scoreOne: "70",
                                userTwo: "Ole",
                                scoreTwo: "50"
                                ),
                            // For spacing
                            new TileText(),
                            new TileText(),
                             CreateGroup(
                                userOne: "Hanne",
                                scoreOne: "40",
                                userTwo: "Jens",
                                scoreTwo: "20"


                                )
                        }
                        }
                    },

                    TileLarge = new TileBinding()

                    {

                        Branding = TileBranding.NameAndLogo,
                        Content = new TileBindingContentAdaptive()
                        {

                            Children =
                        {
                               new TileText()
                               {
                                   Text= "Whistregnskab",
                                   Style = TileTextStyle.Title
                               },
                            CreateGroup(
                                userOne: "Lisbeth",
                                scoreOne: "70",
                                userTwo: "Ole",
                                scoreTwo: "50"
                                ),
                            // For spacing
                            new TileText(),
                            new TileText(),
                             CreateGroup(
                                userOne: "Hanne",
                                scoreOne: "40",
                                userTwo: "Jens",
                                scoreTwo: "20"


                                )
                        }
                        }

                    }

                }

            };
            var tileNotification = new Windows.UI.Notifications.TileNotification(tc.GetXml());
            Windows.UI.Notifications.TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            // long-running startup tasks go here

            NavigationService.Navigate(typeof(Views.MainPage));
            await Task.CompletedTask;
        }

        private static TileGroup CreateGroup(string userOne, string scoreOne, string userTwo, string scoreTwo)
        {
            return new TileGroup()
            {
                Children =
                {
                    new TileSubgroup()
                    {
                        Children =
                        {
                            new TileText()
                            {
                                Text = userOne,
                                Style = TileTextStyle.Subtitle
                            },
                            new TileText()
                            {
                                Text = scoreOne,
                                Style = TileTextStyle.CaptionSubtle
                            }
                        }
                    },
                    new TileSubgroup()
                    {
                        Children =
                        {
                            new TileText()
                            {
                                Text = userTwo,
                                Style = TileTextStyle.Subtitle
                            },
                            new TileText()
                            {
                                Text = scoreTwo,
                                Style = TileTextStyle.CaptionSubtle
                            }
                        }
                    }
                }
            };
        }
    }
}

