﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtUsername.Text=="admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());

            }
            else
            {
                DisplayAlert("Ops..", "Username or Password is incorrect !", "Ok");
            }


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}