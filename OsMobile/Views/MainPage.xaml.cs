using System.ComponentModel;
using OsMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace OsMobile
{
    [DesignTimeVisible(false)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            if (Device.RuntimePlatform == Device.Android)
            {
                On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            }


            Children.Add(new CampanhaPage { Title = "Promo", IconImageSource = "chart_arc" });
            Children.Add(new Dashboard { Title = "O.S", IconImageSource = "finance" });       
            Children.Add(new ConfiguracaoPage { Title = "Configurações",  IconImageSource = "ic_action_configuracao" });

        }
    }
}