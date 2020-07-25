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
    public class MyRecipesRecomendationsVM
    {
        private SimpleList<Recipe> myRecipesRecomendations { get; set; }
        public List<Recipe> myReciperecomendationsIL;

        public MyRecipesRecomendationsVM()
        {
            myRecipesRecomendations = new SimpleList<Recipe>();
            myRecipesRecomendations.setHead(new Node<Recipe>());
            myRecipesRecomendations.getHead().setData(new Recipe("Usuario0", "RecetaRecomendada"));
        }

        public SimpleList<Recipe> getMyrecipesRecomendations()
        {
            return this.myRecipesRecomendations;
        }

        public async void getMyrecipeRecomendationsFS()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/recipes/suggest/ranked");
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            myRecipesRecomendations = JsonConvert.DeserializeObject<SimpleList<Recipe>>(json);
            Node<Recipe> current = this.myRecipesRecomendations.getHead();
            while (current != null)
            {
                myReciperecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
        }

        public List<Recipe> getMyrecipeRecomendationsIL()
        {
            this.getMyrecipeRecomendationsFS();
            return this.myReciperecomendationsIL;
        }
    }
}
