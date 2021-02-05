﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OsMobile.Views;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace OsMobile.Popup
{
    public delegate void ButtonClickedHandler();
   

    public partial class CadastroOkPopUp : PopupPage
    {
        public event ButtonClickedHandler ButtonClicked;




    public CadastroOkPopUp()
        {
            InitializeComponent();

            ButtonClicked += () => { };


        }


        public CadastroOkPopUp(string alerta)
        {
            InitializeComponent();

            lblTexto.Text = alerta;

        }


        protected override void OnAppearingAnimationBegin()
        {
            base.OnAppearingAnimationBegin();

            FrameContainer.HeightRequest = -1;

            if (!IsAnimationEnabled)
            {
                CloseImage.Rotation = 0;
                CloseImage.Scale = 1;
                CloseImage.Opacity = 1;

                LoginButton.Scale = 1;
                LoginButton.Opacity = 1;

               //lblTexto.TranslationX = lblTexto.TranslationX = 0;
                

                return;
            }

            CloseImage.Rotation = 30;
            CloseImage.Scale = 0.3;
            CloseImage.Opacity = 0;

            LoginButton.Scale = 0.3;
            LoginButton.Opacity = 0;

           // lblTexto.TranslationX =  -10;
           // lblTexto.Opacity = 0;
        }

        protected override async Task OnAppearingAnimationEndAsync()
        {
            if (!IsAnimationEnabled)
                return;

            var translateLength = 400u;

           

            await Task.WhenAll(
                CloseImage.FadeTo(1),
                CloseImage.ScaleTo(1, easing: Easing.SpringOut),
                CloseImage.RotateTo(0),
                LoginButton.ScaleTo(1),
                LoginButton.FadeTo(1));
        }

        protected override async Task OnDisappearingAnimationBeginAsync()
        {
            if (!IsAnimationEnabled)
                return;

            var taskSource = new TaskCompletionSource<bool>();

            var currentHeight = FrameContainer.Height;

            await Task.WhenAll(
                //lblTexto.FadeTo(0),
               
                LoginButton.FadeTo(0));

            FrameContainer.Animate("HideAnimation", d =>
            {
                FrameContainer.HeightRequest = d;
            },
            start: currentHeight,
            end: 170,
            finished: async (d, b) =>
            {
                await Task.Delay(300);
                taskSource.TrySetResult(true);
            });

            await taskSource.Task;
        }

        public void SimulateClick()
        {
           
                ButtonClicked();
            
        }

        private async void OnClose(object sender, EventArgs e)
        {
           CloseAllPopup();
        }

        private void OnCloseButtonTapped(object sender, EventArgs e)
        {
            CloseAllPopup();

        }

        protected override bool OnBackgroundClicked()
        {
            CloseAllPopup();

           
            return false;
        }

        private async void CloseAllPopup()
        {

            await PopupNavigation.Instance.PopAllAsync();

            Cadastro oCadastro = new Cadastro();
            oCadastro.SendBackButtonPressed();

        }
    }
}
