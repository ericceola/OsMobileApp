using System;
using System.Collections.Generic;
using OsMobile.Views.Configuracao;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views
{
    public partial class AddOs : ContentPage
    {
        public AddOs()
        {
            InitializeComponent();

            Dashboard._btnCriarOs = true;

        }

        public void InfOs_Click(object sender, EventArgs args)
        {
            try
            {

              Navigation.PushAsync(new PerfilAssistencia());



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            Dashboard._btnCriarOs = true;
            App.Current.MainPage.Navigation.PopAsync();

            return true;

        }


    }
}
