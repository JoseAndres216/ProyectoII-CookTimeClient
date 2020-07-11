using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileClient.Model__Logic_
{
    public class Notification
    {
        public string User { get; set; }

        public string Message { get; set; }

        public Notification(string user, string message)
        {
            this.User = user;
            this.Message = message;
        }
    }
}