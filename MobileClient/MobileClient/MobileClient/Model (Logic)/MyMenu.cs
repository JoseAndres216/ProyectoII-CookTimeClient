using CookTime.Model__Logic_.Data_Structures;

namespace MobileClient.Model__Logic_
{
    public class MyMenu
    {
        private SimpleList<Recipe> ownedRecipes;

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