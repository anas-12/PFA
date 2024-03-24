using System;
using System.Collections.Generic;
using System.ComponentModel;
using UIProject.Models;
using UIProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIProject.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}