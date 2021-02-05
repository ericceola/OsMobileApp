using System;
using System.Collections.Generic;
using OsMobile.ViewModels;
using Xamarin.Forms;

namespace OsMobile.Views
{
    public partial class TransactionsPage : ContentPage
    {
        public TransactionsPage()
        {
            InitializeComponent();

            BindingContext = DataFactory.Places;
        }
    }
}
