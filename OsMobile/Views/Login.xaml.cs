using System;
using System.Collections.Generic;
using OsMobile.Popup;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using XamEffects;

namespace OsMobile.Views
{
    public partial class Login : ContentPage
    {

        public static bool _btnCadastro = true;
        public static bool _btnEsqueceuSenha = true;

        public Login()
        {
            InitializeComponent();


            Sign();
            Cadastro();
            EsqueceuSenha();
        }


        private void Sign()
        {
            Commands.SetTap(btnlogin, new Command(() => {

                if (String.IsNullOrEmpty(txtEmail.Text))
                {

                    PopupNavigation.Instance.PushAsync(new AvisoPopUp("Informe o e-mail."));


                }
                else if (String.IsNullOrEmpty(txtPsw.Text))
                {

                    PopupNavigation.Instance.PushAsync(new AvisoPopUp("Informe o password."));
                }
                else
                {

                    Navigation.PushAsync(new MainPage());
                }

                btnlogin.BackgroundColor = Color.FromHex("#791AE5");
            }));

        }

        private void Cadastro()
        {
            
               
                Commands.SetTap(btnCadastro, new Command(() =>
                {
                    if (_btnCadastro)
                    {
                        _btnCadastro = false;
                        Navigation.PushModalAsync(new Cadastro());
                    }

                }));
            

        }

        private void EsqueceuSenha()
        {


            Commands.SetTap(btnEsqueceuSenha, new Command(() =>
            {
                if (_btnEsqueceuSenha)
                {
                    _btnEsqueceuSenha = false;
                    Navigation.PushModalAsync(new EsqueceuSenha());
                }

            }));


        }

        void LoginClick(System.Object sender, System.EventArgs e)
        {
            btnlogin.BackgroundColor = Color.FromHex("#f7cd34");

         

        }



        void CadastroClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Cadastro());
        }

        void EnviarSenhaClick(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new EsqueceuSenha());
        }
    }
}
