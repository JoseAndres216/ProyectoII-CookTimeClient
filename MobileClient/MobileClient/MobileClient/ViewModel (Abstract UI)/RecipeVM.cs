using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class RecipeVM
    {
        private CookTime.Model__Logic_.Data_Structures.SimpleList<Recipe> post { get; set; }

        public RecipeVM()
        {
            Client instance = Client.getInstance();
            CookTime.Model__Logic_.User user = instance.getUser();
            CookTime.Model__Logic_.Data_Structures.Stack<Recipe> stack = user.getNewsfeed();
            CookTime.Model__Logic_.Data_Structures.SimpleList<Recipe> recipesList = stack.getElements();

            this.post = recipesList;
        }

        public CookTime.Model__Logic_.Data_Structures.SimpleList<Recipe> getPosts()
        {
            return this.post;
        }

        public List<Recipe> getPostsIL()
        {
            List<Recipe> myPostsIL = new List<Recipe>();
            Node<Recipe> current = this.post.getHead();
            while (current != null)
            {
                myPostsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myPostsIL;
        }
    }
}
