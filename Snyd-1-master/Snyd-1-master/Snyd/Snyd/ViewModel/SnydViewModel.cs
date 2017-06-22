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
using System.Net.Http.Headers;

namespace Snyd.ViewModel
{
   public class SnydViewModel : INotifyPropertyChanged 
    {
        //public Game game;
        //public ICommand CreateCommand { get; set; }
        const string serverUrl = "http://localhost:1182/";
        HttpClientHandler handler;
        public event PropertyChangedEventHandler PropertyChanged;

        //public ObservableCollection<Game> games { get; set; }
        public SnydViewModel()
        {
            //games = new ObservableCollection<Game>();

        }

        public List<Game> FindSpil()
        {
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("api/game/discover").Result;

                if(response.IsSuccessStatusCode)
                {
                    //var gameList = response.Content.ReadAsStringAsync<Game>().Result;
                    //var games = Newtonsoft.JsonConvert < List<Game>(response.ReadAsString);

                }
                return null;
            }
        }

       

        //var games = NewtonSoft.JsonConvert < List<Game>(response.ReadAsString)

        //[NotifyPropertyChangedInvocator]
        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
