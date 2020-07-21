using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyNotificationsVM
    {
        private CookTime.Model__Logic_.Data_Structures.Stack<string> myNotifications { get; set; }

        public MyNotificationsVM()
        {
            myNotifications = Client.getInstance().getUser().getNotifications();
        }

        public CookTime.Model__Logic_.Data_Structures.Stack<string> getMynotifications()
        {
            return this.myNotifications;
        }

        public List<string> getMynotificationsIL()
        {
            List<string> myNotificationsIL = new List<string>();
            Node<string> current = this.myNotifications.getElements().getHead();
            while (current != null)
            {
                myNotificationsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myNotificationsIL;
        }
    }
}
