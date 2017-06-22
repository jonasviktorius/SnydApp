using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Net.Http;
using System.Net;

namespace Snyd.ViewModel
{
   public class SnydViewModel : INotifyPropertyChanged 
    {
        //public Game game;
        //public ICommand CreateCommand { get; set; }
        const string serverUrl = "http://localhost:1182/";
        //HttpClientHandler handler; 
        public event PropertyChangedEventHandler PropertyChanged;

        //public ObservableCollection<Game> games { get; set; }
        public SnydViewModel()
        {
            //games = new ObservableCollection<Game>();

        }

        public Game FindSpil()
        {
            using (var client = new HttpClient)
        }

        var response = System.Net.HttpClient.Get("localhost:1182/api/game/discover")

        var games = NewtonSoft.JsonConvert < List<Game>(response.ReadAsString)

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
