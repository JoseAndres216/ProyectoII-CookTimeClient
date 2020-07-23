using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyEnterprisesRecomendationsVM
    {
        private SimpleList<Enterprise> myEnterprisesrecomendations { get; set; }

        public MyEnterprisesRecomendationsVM()
        {
            myEnterprisesrecomendations = new SimpleList<Enterprise>();
            myEnterprisesrecomendations.setHead(new Node<Enterprise>());
            myEnterprisesrecomendations.getHead().setData(new Enterprise("email", "EnterpriseRecomendada", "pass"));
        }

        public SimpleList<Enterprise> getMyenterpriseRecomendations()
        {
            return this.myEnterprisesrecomendations;
        }

        public List<Enterprise> getMyenterpriseRecomendationsIL()
        {
            List<Enterprise> myEnterpriserecomendationsIL = new List<Enterprise>();
            Node<Enterprise> current = this.myEnterprisesrecomendations.getHead();
            while (current != null)
            {
                myEnterpriserecomendationsIL.Add(current.getdata());
                current = current.getNext();
            }
            return myEnterpriserecomendationsIL;
        }
    }
}
