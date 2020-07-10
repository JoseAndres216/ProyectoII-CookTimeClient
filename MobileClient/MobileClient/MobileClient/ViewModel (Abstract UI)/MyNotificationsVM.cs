using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyNotificationsVM
    {
        public List<Notification> MyNotifications { get; set; }

        public MyNotificationsVM()
        {
            MyNotifications = new MyNotifications().GetMyNotifications();
        }
    }
}
