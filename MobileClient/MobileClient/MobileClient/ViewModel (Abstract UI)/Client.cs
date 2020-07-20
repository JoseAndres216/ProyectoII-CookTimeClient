using CookTime.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.ViewModel__Abstract_UI_
{
    class Client
    {
        private static Client instance = null;
        private User user;

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

        public static Client getInstance()
        {
            if (instance == null)
            {
                instance = new Client();
            }
            return instance;
        }
    }
}
