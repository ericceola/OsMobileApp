using System;
using System.Collections.Generic;
using OsMobile.Views.Configuracao;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views
{
    public partial class Dashboard : ContentPage
    {
        public static bool _btnCriarOs = true;
        public static bool _btnPerfilUsuario = true;
        public static bool _btnOSReparada = true;
        public static bool _btnAlterarSenha = true;

        public Dashboard()
        {
            InitializeComponent();

            Commands.SetTap(btnCriarOs, new Command(() =>
            {
                if (_btnCriarOs)
                {
                    _btnCriarOs = false;
                    Navigation.PushAsync(new AddOs());
                }

            }));

            Commands.SetTap(btnPerfilUsuario, new Command(() =>
            {
                if (_btnPerfilUsuario)
                {
                    _btnPerfilUsuario = false;
                    Navigation.PushModalAsync(new PerfilAssistencia());
                }

            }));

            Commands.SetTap(btnOSReparada, new Command(() =>
            {
                if (_btnOSReparada)
                {
                    _btnOSReparada = false;
                     Navigation.PushModalAsync(new ListOs());
                }

            }));

            Commands.SetTap(btnAlterarSenha, new Command(() =>
            {
                if (_btnAlterarSenha)
                {
                    _btnAlterarSenha = false;
                    Navigation.PushModalAsync(new AlterarSenha());
                }

            }));
        }
    }
}
