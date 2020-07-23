using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.Model__Logic_
{
    public class Enterprise
    {
        public string email { get; set; }
        //public MyMenu MyMenu { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        //public string Contactinfo { get; set; }
        //public int Rating { get; set; }
        public string image = "StandartEnterprisePic.png";

        public Enterprise(string email, string name, string password)
        {
            this.email = email;
            this.name = name;
            this.password = password;
        }

        public Enterprise() { }
    }
}
