using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.ViewModel__Abstract_UI_
{
    public class MyMenuVM
    {
        private SimpleList<Recipe> myMenu { get; set; }

        public MyMenuVM()
        {
            myMenu = Client.getInstance().getUser().getMymenu();
        }

        public SimpleList<Recipe> getMymenu()
        {
            return this.myMenu;
        }

        public List<Recipe> getMymenuIL()
        {
            List<Recipe> myMenuIL = new List<Recipe>();
            Node<Recipe> current = this.myMenu.getHead();
            while (current != null)
            {
                myMenuIL.Add(current.getdata());
                current = current.getNext();
            }
            return myMenuIL;
        }
    }
}
