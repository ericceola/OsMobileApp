using System;
using System.Collections.Generic;
using System.Linq;
using OsMobile.Models;
using OsMobile.ViewModels;
using Plugin.SharedTransitions;
using Xamarin.Forms;

namespace OsMobile.Views
{
    public partial class ListOs : ContentPage
    {
        private readonly ListOsViewModel viewModel;

        public ListOs()
        {
            InitializeComponent();

            viewModel = new ListOsViewModel();

            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.ListaOs.Count == 0)
                viewModel.LoadCommand.Execute(null);
        }

        private async void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;
            if (!(e.CurrentSelection.First() is OrdemServico item))
                return;


            if (sender is CollectionView lv) lv.SelectedItem = null;

            //this is required in order to pass the views to animate
            SharedTransitionShell.SetTransitionSelectedGroup(this, item.Id.ToString());

            //await   Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
           // await Navigation.PushAsync(new ItemDetailPage2());
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
    }
}
