using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.ViewModel__Abstract_UI_
{

    class Client
    {

        public const string HTTP_BASE_URL = "http://192.168.100.11:8080/CookTimeServer/";
        private static Client instance = null;
        private User user;
        private Enterprise enterprise = new Enterprise();
        public bool isUser = false;
        public bool isEnterprise = false;

        private Client()
        {

        }

        public void setUser(User user)
        {
            this.user = user;
        }

        public User getUser()
        {
            return this.user;
        }

        public void setEnterprise(User user)
        {
            this.user = user;
        }

        public User getEnterprise()
        {
            return this.user;
        }

        public static Client getInstance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }
        /*
         * Method for getting the user's feed, converted to a C# list, for updating the user's feed screen. 
         */
        public List<Recipe> getFeedIL()
        {
            Model__Logic_.Data_Structures.Stack<Recipe> temp = this.user.getNewsfeed();
            List<Recipe> result  = new List<Recipe>();
            Node<Recipe> current = temp.getElements().getHead();
            while(current != null)
            {
                result.Add(current.getdata());
                current = current.getNext();
            }
            return result;
        }
    }
}
