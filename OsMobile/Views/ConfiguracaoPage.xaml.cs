using System;
using System.Collections.Generic;
using OsMobile.Views.Configuracao;
using Xamarin.Forms;
using XamEffects;

namespace OsMobile.Views
{
    public partial class ConfiguracaoPage : ContentPage
    {
        public static bool _btnConfigurarOS = true;
        public static bool _btnPerfilUsuario = true;
        public static bool _btnLogoAssistencia = true;
        public static bool _btnAlterarSenha = true;

        public ConfiguracaoPage()
        {
            InitializeComponent();

            Commands.SetTap(btnConfigurarOS, new Command(() =>
            {
                if (_btnConfigurarOS)
                {
                    _btnConfigurarOS = false;
                     Navigation.PushModalAsync(new ConfigurarOS());
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

            Commands.SetTap(btnLogoAssistencia, new Command(() =>
            {
                if (_btnLogoAssistencia)
                {
                    _btnLogoAssistencia = false;
                    // Navigation.PushModalAsync(new Cadastro());
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
