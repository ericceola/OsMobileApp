using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsMobile.Models;
using OsMobile.ViewModels;
using Xamarin.Forms;

namespace OsMobile.Views
{
    public partial class CampanhaPage : BasePage
    {
        public CampanhaPage()
        {
            InitializeComponent();

            this.BindingContext = new CampanhaViewModel();
                
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

    }
}
