using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyMenuVM
    {
        public List<Recipe> MyMenu { get; set; }

        public MyMenuVM()
        {
            MyMenu = new MyMenu().GetMyMenu();
        }
    }
}
