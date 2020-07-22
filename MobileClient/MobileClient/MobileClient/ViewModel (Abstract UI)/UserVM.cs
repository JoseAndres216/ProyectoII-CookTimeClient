using CookTime.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.ViewModel__Abstract_UI_
{
    class UserVM
    {
        public List<User> Users { get; set; }

        public UserVM()
        {
            Users = null;
        }
    }
}
