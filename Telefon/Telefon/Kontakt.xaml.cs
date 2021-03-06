﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telefon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kontakt : ContentPage
    {
        public Kontakt()
        {
            InitializeComponent();
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Možnosti", "OK");
        }
        void SMSTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Poslat SMS", "OK");
        }
        void TelTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            DisplayAlert("Alert", "Volat", "OK");
        }
        void BackTapped(object sender, EventArgs args)
        {
            //App.Current.MainPage = new Seznam();
            Navigation.PushModalAsync(new Seznam());

        }
    }
}