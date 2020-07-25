
using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using MobileClient.Model__Logic_;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CookTime.ViewModel__Abstract_UI_
{
    class MySearches
    {
        private SimpleList<Recipe> recipesResults;
        private SimpleList<User> usersResults;
        private SimpleList<Enterprise> enterprisesResults;

        private List<Recipe> recipesResultsIL;
        private List<User> usersResultsIL;
        private List<Enterprise> enterprisesResultsIL;

        public MySearches()
        {
        }

        private async void RecipesRankedResult(String key)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/recipes/rated?key=" + key);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            recipesResults = JsonConvert.DeserializeObject<SimpleList<Recipe>>(json);
            Node<Recipe> current = this.recipesResults.getHead();
            this.recipesResultsIL = new List<Recipe>();
            while (current != null)
            {
                this.recipesResultsIL.Add(current.getdata());
                current = current.getNext();
            }
        }
        public List<Recipe> getRecipesresultsRankedIL(String key)
        {
            this.RecipesRankedResult(key);
            return this.recipesResultsIL;
        }

        private async void RecipesDifficultedResult(string key)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/recipes/difficulty?key=" + key);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            recipesResults = JsonConvert.DeserializeObject<SimpleList<Recipe>>(json);
            Node<Recipe> current = this.recipesResults.getHead();
            this.recipesResultsIL.Clear();
            while (current != null)
            {
                this.recipesResultsIL.Add(current.getdata());
                current = current.getNext();
            }
        }
        public List<Recipe> getRecipesresultsDifficultedIL(String key)
        {
            this.RecipesDifficultedResult(key);
            return this.recipesResultsIL;
        }

        private async void RecipesDuratedResult(string key)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/recipes/duration?key=" + key);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            recipesResults = JsonConvert.DeserializeObject<SimpleList<Recipe>>(json);
            Node<Recipe> current = this.recipesResults.getHead();
            this.recipesResultsIL.Clear();
            while (current != null)
            {
                this.recipesResultsIL.Add(current.getdata());
                current = current.getNext();
            }
        }
        public List<Recipe> getRecipesresultsDuratedIL(String key)
        {
            this.RecipesDuratedResult(key);
            return this.recipesResultsIL;
        }


        private async void UsersRankedResult(string key)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/users/rated?key=" + key);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            usersResults = JsonConvert.DeserializeObject<SimpleList<User>>(json);
            Node<User> current = this.usersResults.getHead();
            this.usersResultsIL.Clear();
            while (current != null)
            {
                this.usersResultsIL.Add(current.getdata());
                current = current.getNext();
            }
        }
        public List<User> getUsersresultsRankedIL(string key)
        {
            this.UsersRankedResult(key);
            return this.usersResultsIL;
        }

        private async void EnterprisesRankedResult(string key)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "search/enterprises/rated?key=" + key);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            String json = response.Content.ReadAsStringAsync().Result;
            enterprisesResults = JsonConvert.DeserializeObject<SimpleList<Enterprise>>(json);
            Node<Enterprise> current = this.enterprisesResults.getHead();
            this.enterprisesResultsIL.Clear();
            while (current != null)
            {
                this.enterprisesResultsIL.Add(current.getdata());
                current = current.getNext();
            }
        }
        public List<Enterprise> getEnterprisesresultsRankedIL(String key)
        {
            this.EnterprisesRankedResult(key);
            return this.enterprisesResultsIL;
        }
    }
}





