using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyUsersRecomendationsVM
    {
        private SimpleList<User> myUsersrecomendations { get; set; }
        public List<User> myUserrecomendationsIL;

        public MyUsersRecomendationsVM()
        {
            myUsersrecomendations = new SimpleList<User>();
            myUsersrecomendations.setHead(new Node<User>());
            myUsersrecomendations.getHead().setData(new User("email", "pass", "UsuarioRecomendado", 0));
        }

        public SimpleList<User> getUserMyrecomendations()
        {
            return this.myUsersrecomendations;
        }

        public async void getMyuserRecomendationsFS()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "/search/users/suggest/ranked");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            myUsersrecomendations = JsonConvert.DeserializeObject<SimpleList<User>>(json);
            Node<User> current = this.myUsersrecomendations.getHead();
            while (current != null)
            {
                myUserrecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
        }

        public List<User> getMyuserRecomendationsIL()
        {
            this.getMyuserRecomendationsFS();
            return this.myUserrecomendationsIL;
        }
    }
}
