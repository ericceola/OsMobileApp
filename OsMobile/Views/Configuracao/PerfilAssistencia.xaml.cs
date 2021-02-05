using System;
using System.Collections.Generic;
using OsMobile.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views.Configuracao
{
    public delegate void SimpleDelegate1();

    public partial class PerfilAssistencia : ContentPage
    {
        public PerfilAssistencia()
        {
            InitializeComponent();

            SimpleDelegate1 simpleDelegate = new SimpleDelegate1(ButtonClicked);

            simpleDelegate();

            SalvarCadastro();
        }

        private void SalvarCadastro()
        {


            Commands.SetTap(btnSalvar, new Command(() =>
            {
                PopupNavigation.Instance.PushAsync(new EsqueceuSenhaPop("Cadastro salvo com sucesso!"));

            }));


        }

        public static void ButtonClicked()
        {
            ConfiguracaoPage._btnPerfilUsuario = true;


            App.Current.MainPage.Navigation.PopModalAsync();
        }

        void CancelarClick(System.Object sender, System.EventArgs e)
        {
            OnBackButtonPressed();
        }

        protected override bool OnBackButtonPressed()
        {
            ConfiguracaoPage._btnPerfilUsuario = true;
            App.Current.MainPage.Navigation.PopModalAsync();

           
                return true;
           

        }
    }
}
