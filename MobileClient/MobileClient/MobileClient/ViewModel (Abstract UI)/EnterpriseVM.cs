using CookTime.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookTime.ViewModel__Abstract_UI_
{
    class EnterpriseVM
    {
        public List<Enterprise> Enterprises { get; set; }

        public EnterpriseVM()
        {
            Enterprises = new Enterprise().GetEnterprises();
        }
    }
}
