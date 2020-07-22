﻿using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using CookTime.Views__UI_;
using MobileClient.Model__Logic_;
using MobileClient.ViewModel__Abstract_UI_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClient.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            MyMenuVM vM;

            InitializeComponent();
            vM = new MyMenuVM();
            MyMenuList.ItemsSource = vM.getMymenuIL();
            lblUserName.Text = Client.getInstance().getUser().getName();
        }


        private void btnChangeImage_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCreateEnterprise_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new CreateEnterprise());
        }

        private async void itemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await this.Navigation.PushModalAsync(new PostInfo(details.getName(), details.getUser(), details.getType(), details.getServings(), details.getDuration().ToString(),
                details.getTiming(), details.getDifficulty().ToString(), details.getTags(), details.getIngredients(), details.getSteps(), details.getPrice(), details.getImage()));
        }

        private void btnBecomeChef_Clicked(object sender, EventArgs e)
        {

        }
    }
}