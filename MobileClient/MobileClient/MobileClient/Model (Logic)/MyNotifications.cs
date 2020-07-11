using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileClient.Model__Logic_
{
    public class MyNotifications
    {
     
        public List<Notification> GetMyNotifications()
        {
            List<Notification> MyNotifications = new List<Notification>()
            {
                new Notification("NoobMaster69", " is a new follower.")
            };
            return MyNotifications;

        }
    }
}