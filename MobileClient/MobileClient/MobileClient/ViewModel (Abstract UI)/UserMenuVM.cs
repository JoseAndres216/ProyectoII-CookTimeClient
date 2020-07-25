using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class UserMenuVM
    {
        private SimpleList<Recipe> userMenuVM { get; set; }

        public UserMenuVM()
        {
            userMenuVM = Client.getInstance().getUser().getMymenu();
        }

        public SimpleList<Recipe> getMymenu()
        {
            return this.userMenuVM;
        }

        public List<Recipe> getUserMenuIL(String email)
        {
            return Client.getInstance().getUserMenuILAsync(email);
        }
    }
}
