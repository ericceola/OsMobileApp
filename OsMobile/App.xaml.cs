using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using OsMobile.Views;
using OsMobile.ViewModels;
using OsMobile.Controls;

namespace OsMobile
{
    public partial class App : PrismApplication
    {
        public static Theme AppTheme { get; set; }
        public static INavigation Navigation { get; private set; }
        public bool Logado { get; set; }
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
            
        }

        public bool DoBack
        {
            get
            {
                NavigationPage mainPage = MainPage as NavigationPage;
                if (mainPage != null)
                {
                    return mainPage.Navigation.NavigationStack.Count > 1;
                }
                return true;
            }
        }

        protected async override  void OnInitialized()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this);
          

            Logado = false;
            if (Logado)
            {
                var startPage = nameof(NavigationPage) + "/" + nameof(MainPage);
                 await NavigationService.NavigateAsync(startPage);
            }
            else
            {


               MainPage = GetMainPage(new Login());
            }

         //   await NavigationService.NavigateAsync($"{nameof(ExtendedNavigationPage)}/{nameof(ListaOs)}");
            //
        }

        public static Page GetMainPage(Page pagina)
        {
            var rootPage = new NavigationPage(pagina);
            Navigation = rootPage.Navigation;
            return rootPage;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
           // containerRegistry.RegisterForNavigation<DashboardPage, DashboardViewModel>();
            containerRegistry.RegisterForNavigation<TransactionsPage>();
            containerRegistry.RegisterForNavigation<ConfiguracaoPage>();


            ////////
            containerRegistry.RegisterForNavigation<ExtendedNavigationPage>();
            containerRegistry.RegisterForNavigation<ListaOs>();
        }

        public enum Theme { Light, Dark }
    }
}
