using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Snyd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FindGameView : ContentPage
    {
        public FindGameView()
        {
            InitializeComponent();
        }

        private void ChooseGame_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameView());
        }
    }
}