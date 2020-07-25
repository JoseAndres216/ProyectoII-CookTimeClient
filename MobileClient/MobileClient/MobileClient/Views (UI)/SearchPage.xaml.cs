using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookTime.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        MySearches search = new MySearches();
        public SearchPage()
        {
            InitializeComponent();
            pckType.Items.Add("Recipes");
            pckType.Items.Add("Users");
            pckType.Items.Add("Enterprises");

            pckFilter.Items.Add("Rating");
            pckFilter.Items.Add("Difficulty");
            pckFilter.Items.Add("Duration");
        }

        private void SearchList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            this.Navigation.PushModalAsync(new PostInfo(details));
        }

        private void pckType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Clicked(sender, e);
        }
        private void pckFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Clicked(sender, e);
        }

        private async void btnSearch_Clicked(object sender, EventArgs e)
        {
            if(pckType.SelectedItem == null)
            {
                await DisplayAlert("Stop", "No type selected", "OK");
            }
            if (pckType.SelectedItem.Equals("Users") || pckType.SelectedItem.Equals("Enterprises"))
            {
                pckFilter.SelectedItem = "Rating";
                pckFilter.IsEnabled = false;
                if (pckType.SelectedItem.Equals("Users"))
                {
                    SearchResultList.ItemsSource = search.getUsersresultsRankedIL(txbSearch.Text);
                  
                }
                else
                {
                    SearchResultList.ItemsSource = search.getEnterprisesresultsRankedIL(txbSearch.Text);
                }
            }
            else
            {
                pckFilter.IsEnabled = true;
                if (pckFilter.SelectedItem == null)
                {
                    SearchResultList.ItemsSource = search.getRecipesresultsRankedIL(txbSearch.Text);
                }
                else if (pckFilter.SelectedItem.Equals("Rating"))
                {
                    SearchResultList.ItemsSource = search.getRecipesresultsRankedIL(txbSearch.Text);
                }
                else if (pckFilter.SelectedItem.Equals("Difficulty"))
                {
                    SearchResultList.ItemsSource = search.getRecipesresultsDifficultedIL(txbSearch.Text);
                }
                else
                {
                    SearchResultList.ItemsSource = search.getRecipesresultsDuratedIL(txbSearch.Text);
                }
            }
        }







    }
}