using CookTime.Model__Logic_.Data_Structures;
using Newtonsoft.Json;

namespace MobileClient.Model__Logic_
{
    public class MyMenu
    {
        [JsonProperty] private SimpleList<Recipe> ownedRecipes;

        public MyMenu()
        {
            ownedRecipes = new SimpleList<Recipe>();
        }

        public void setOwnedrecipes(SimpleList<Recipe> ownedRecipes)
        {
            this.ownedRecipes = ownedRecipes;
        }

        public SimpleList<Recipe> getOwnedrecipes()
        {
            return this.ownedRecipes;
        }
    }
}