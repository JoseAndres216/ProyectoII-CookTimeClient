using CookTime.Model__Logic_.Data_Structures;
using MobileClient.Model__Logic_;
using Newtonsoft.Json;
using System;


namespace CookTime.Model__Logic_
{
    public class User
    {

        [JsonProperty] public string email { get; set; }
        [JsonProperty] public string name { get; set; }
        [JsonProperty] public string password { get; set; }
        [JsonProperty] public int age { get; set; }

        [JsonProperty] public int rating;
        [JsonProperty] public bool isChef;
        [JsonProperty] public Data_Structures.Stack<string> notifications;
        [JsonProperty] public SimpleList<User> followers;
        [JsonProperty] public Data_Structures.Stack<Recipe> newsFeed;
        [JsonProperty] public MyMenu MyMenu;
        public string image = "StandartUserPic.png";


        public User(string email, string password, string name, int age)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.age = age;

            this.newsFeed = new Stack<Recipe>();
            this.notifications = new Stack<string>();
            this.MyMenu = new MyMenu();
            this.followers = new SimpleList<User>();
            this.rating = 0;
            this.isChef = false;
            
        }

        public User()
        {

        }
        override
        public String ToString()
        {
            return "User{ name: " + this.name + ", newsFeed: " + this.newsFeed + "}";
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public Data_Structures.Stack<string> getNotifications()
        {
            return this.notifications;
        }

        public SimpleList<Recipe> getMymenu()
        {
            return this.MyMenu.getOwnedrecipes();
        }

        public Data_Structures.Stack<Recipe> getNewsfeed()
        {
            if (this.newsFeed != null)
            {
                return this.newsFeed;
            }
            else
            {
                Console.Out.WriteLine("Null news feed, User: " + this.email);
                return null;
            }

        }

        /* 
         * recipe/create
         * recipe/like
         * recipe/share
         * recipe/rate
         * recipe/comment
         * mymenu/recent
         *          /difficulty
         *          /ranked
         * notifications/
         * followers/
         * followers/
         * request/chef/
         * 
         * NEWSFEED/  
         */
    }
}
