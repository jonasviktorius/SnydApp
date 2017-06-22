﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Snyd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void CreateGameBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateGameView());
        }
        private void FindGameBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FindGameView());
        }
    }
}
