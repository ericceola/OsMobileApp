using System;
using System.Collections.Generic;
using OsMobile.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views
{ 
    

    public partial class Cadastro : ContentPage
    {

        public delegate void SimpleDelegate();

        public Cadastro()
        {
            InitializeComponent();

            SimpleDelegate simpleDelegate = new SimpleDelegate(ButtonClicked);

            simpleDelegate();
            AdicionarCadastro();
        }

        public static void ButtonClicked()
        {
            Login._btnCadastro = true;


            App.Current.MainPage.Navigation.PopModalAsync();
        }

        void CancelarClick(System.Object sender, System.EventArgs e)
        {
            OnBackButtonPressed();
        }


        private void AdicionarCadastro()
        {


            Commands.SetTap(btnRegistar, new Command(() =>
            {

                PopupNavigation.Instance.PushAsync(new CadastroOkPopUp("Cadastro realizado com sucesso!"));

            }));


        }



        protected override bool OnBackButtonPressed()
        {
            Login._btnCadastro = true;
            App.Current.MainPage.Navigation.PopModalAsync();

                return true;
            

           

        }
    }
}
