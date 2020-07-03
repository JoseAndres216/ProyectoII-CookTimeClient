using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class RecipeVM
    {
        public List<Recipe> Posts { get; set; }

        public RecipeVM()
        {
            Posts = new Recipe().GetRecipes();
        }
    }
}
