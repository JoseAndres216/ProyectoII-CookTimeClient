using CookTime.Model__Logic_.Data_Structures;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    public class User { 

        private string email { get; set; }
        private string name { get; set; }
        private string password { get; set; }
        private int age { get; set; }
        private int rating;
        private bool isChef;
        private Data_Structures.Stack<string> notifications;
        private SimpleList<User> followers;
        private Data_Structures.Stack<Recipe> newsFeed;
        private MyMenu MyMenu;


        public User(string email, string password, string name, int age)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.age = age;
            this.rating = 0;
            this.isChef = false;
            this.notifications = new Data_Structures.Stack<string>();
            this.followers = new SimpleList<User>();
            newsFeed = new Data_Structures.Stack<Recipe>();
            MyMenu = new MyMenu();
        }

        public User()
        {

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
            return this.newsFeed;
        }
    }
}
