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
        private CookTime.Model__Logic_.Data_Structures.Stack<Recipe> Posts { get; set; }

        public RecipeVM()
        {
            this.Posts = Client.getInstance().getUser().getNewsfeed();
        }

        public CookTime.Model__Logic_.Data_Structures.Stack<Recipe> getPosts()
        {
            return this.Posts;
        }

        public List<Recipe> getPostsIL()
        {
            List<Recipe> myPostsIL = new List<Recipe>();
            Node<Recipe> current = this.Posts.getElements().getHead();
            while (current != null)
            {
                myPostsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myPostsIL;
        }
    }
}
