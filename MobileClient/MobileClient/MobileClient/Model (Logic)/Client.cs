using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using MobileClient.Model__Logic_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;

namespace CookTime.ViewModel__Abstract_UI_
{

    class Client
    {

        public const string HTTP_BASE_URL = "http://192.168.100.11:8080/CookTimeServer/";
        private static Client instance = null;
        private User user;
        private Enterprise enterprise = new Enterprise();
        public bool isUser = false;
        public bool isEnterprise = false;

        public List<Recipe> UserMenu { get; private set; }

        private Client()
        {

        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public User getUser()
        {
            return this.user;
        }

        public void setEnterprise(User user)
        {
            this.user = user;
        }

        public User getEnterprise()
        {
            return this.user;
        }

        public static Client getInstance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }

        /*
         * Method for getting the user's feed, converted to a C# list, for updating the user's feed screen. 
         */
        public List<Recipe> getFeedIL()
        {

            Model__Logic_.Data_Structures.SimpleList<Recipe> temp = this.user.getNewsfeed().getElements();
            List<Recipe> myMenuIL = new List<Recipe>();
            Node<Recipe> current = temp.getHead();
            while (current != null)
            {
                myMenuIL.Add(current.getdata());
                current = current.getNext();
            }
            return myMenuIL;
        }
        public List<Recipe> getUserMenuILAsync(String email)
        {
            this.getUserMenuILAsyncAux(email);
            return this.UserMenu;
        }
        public async void getUserMenuILAsyncAux(String email)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/menu/recent?user=" + email);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                String json = response.Content.ReadAsStringAsync().Result;
                SimpleList<Recipe> temp = JsonConvert.DeserializeObject<SimpleList<Recipe>>(json);
                UserMenu = new List<Recipe>();

                Node<Recipe> current = temp.getHead();
                while (current != null)
                {
                    UserMenu.Add(current.getdata());
                    current = current.getNext();
                }
            }
            catch
            {

            }
        }
    }
}
