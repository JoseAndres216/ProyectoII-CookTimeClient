using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileClient.Model__Logic_
{
    public class MyMenu
    {
        /*Name of the recipe, User that created the recipe, Type (Breakfast, lunch, etc), Servings, Duration of preparation
         * Timing (Entry, main dish, dessert, drink, etc), Difficulty, Tags by type of diet(vegan, celiac, keto),
         * Ingredients, Steps to prepare the dish, Price(estimated), image of the Recipe
         */
     
        public List<Recipe> GetMyMenu()
        {
            List<Recipe> MyMenu = new List<Recipe>()
            {
                new Recipe(){ Name = "Macarrones con tomatico", User = "ElAbduzcan", Type = "Lunch", Servings = 3, Duration = "30 minutes", Timing = "Lunch", Difficulty = "Begginer",
                    Tags = "Auronplay", Ingredients = "Macarrones, Tomatico", Steps = "Hierva los macarrones, echeles el tomatico y monche",
                    Price = 2000, Image = "https://jumbo.vteximg.com.br/arquivos/ids/337515/Principal-5649.jpg?v=637245668229800000"},
            };
            return MyMenu;

        }
    }
}