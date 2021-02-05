using System;
using System.Collections.Generic;
using OsMobile.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views
{
    public delegate void SimpleDelegate();

    public partial class EsqueceuSenha : ContentPage
    {
        public EsqueceuSenha()
        {
            InitializeComponent();

            SimpleDelegate simpleDelegate = new SimpleDelegate(ButtonClicked);

            simpleDelegate();

            EnviarSenha();
        }

        private void EnviarSenha()
        {


            Commands.SetTap(btnEnviarSenha, new Command(() =>
            {
                PopupNavigation.Instance.PushAsync(new EsqueceuSenhaPop("Senha enviada no e-mail de cadastro!"));

            }));


        }

        public static void ButtonClicked()
        {
            Login._btnEsqueceuSenha = true;


            App.Current.MainPage.Navigation.PopModalAsync();
        }

        void CancelarClick(System.Object sender, System.EventArgs e)
        {
            OnBackButtonPressed();
        }

        protected override bool OnBackButtonPressed()
        {
            Login._btnEsqueceuSenha = true;
            App.Current.MainPage.Navigation.PopModalAsync();

          
                return true;
            

        }
    }
}
