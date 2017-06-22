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
    public partial class CreateGameView : ContentPage
    {
        public CreateGameView()
        {
            InitializeComponent();
        }

        private void CreateBtn_OnClicked(object sender, EventArgs e)
        {
        }
    }
}