using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyRecipesRecomendationsVM
    {
        private SimpleList<Recipe> myRecipesRecomendations { get; set; }

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

        public List<Recipe> getMyrecipesRecomendationsIL()
        {
            List<Recipe> myRecomendationsIL = new List<Recipe>();
            Node<Recipe> current = this.myRecipesRecomendations.getHead();
            while (current != null)
            {
                myRecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myRecomendationsIL;
        }
    }
}
