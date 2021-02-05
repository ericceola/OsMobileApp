using System;
using System.Collections.Generic;
using OsMobile.ViewModels;
using Xamarin.Forms;

namespace OsMobile.Views
{
    public partial class BasePage : ContentPage
    {
        public BasePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if (BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);
        }
    }
}
