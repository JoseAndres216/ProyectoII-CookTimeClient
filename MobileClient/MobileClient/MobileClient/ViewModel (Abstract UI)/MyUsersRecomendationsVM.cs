using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyUsersRecomendationsVM
    {
        private SimpleList<User> myUsersrecomendations { get; set; }

        public MyUsersRecomendationsVM()
        {
            myUsersrecomendations = new SimpleList<User>();
            myUsersrecomendations.setHead(new Node<User>());
            myUsersrecomendations.getHead().setData(new User("email", "pass", "UsuarioRecomendado", 0));
        }

        public SimpleList<User> getUserMyrecomendations()
        {
            return this.myUsersrecomendations;
        }

        public List<User> getUserMyrecomendationsIL()
        {
            List<User> myRecomendationsIL = new List<User>();
            Node<User> current = this.myUsersrecomendations.getHead();
            while (current != null)
            {
                myRecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myRecomendationsIL;
        }
    }
}
