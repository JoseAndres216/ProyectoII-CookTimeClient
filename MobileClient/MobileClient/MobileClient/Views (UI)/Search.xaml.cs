using CookTime.Model__Logic_;
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
    public partial class Search : ContentPage
    {
        RecipeVM vM;
        UserVM UserVM;
        EnterpriseVM EnterpriseVM;
        public Search()
        {
            InitializeComponent();
            vM = new RecipeVM();
            UserVM = new UserVM();
            EnterpriseVM = new EnterpriseVM();
            RecommendationList.ItemsSource = vM.Posts;
            BindingContext = RecommendationList;
            
            recipesButton.IsEnabled = false;
            usersButton.IsEnabled = true;
            companiesButton.IsEnabled = true;

        }

        private void RecommendationList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            this.Navigation.PushModalAsync(new PostInfo(details.Name, details.User, details.Type, details.Servings, details.Duration,
                details.Timing, details.Difficulty, details.Tags, details.Ingredients, details.Steps, details.Price, details.Image));
        }

        private void recipesButton_Clicked(object sender, EventArgs e)
        {
            RecommendationList.ItemsSource = vM.Posts;

            recipesButton.IsEnabled = false;
            usersButton.IsEnabled = true;
            companiesButton.IsEnabled = true;
        }

        private void usersButton_Clicked(object sender, EventArgs e)
        {
            RecommendationList.ItemsSource = UserVM.Users;
            recipesButton.IsEnabled = true;
            usersButton.IsEnabled = false;
            companiesButton.IsEnabled = true;
        }

        private void companiesButton_Clicked(object sender, EventArgs e)
        {
            RecommendationList.ItemsSource = EnterpriseVM.Enterprises;

            recipesButton.IsEnabled = true;
            usersButton.IsEnabled = true;
            companiesButton.IsEnabled = false;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(recipesButton.IsEnabled == false)
            {
                var keyword = RecoSearchBar.Text;
                RecommendationList.ItemsSource = vM.Posts.Where(i => i.Name.ToLower().Contains(keyword.ToLower()));
            }
            else if(usersButton.IsEnabled == false)
            {
                var keyword = RecoSearchBar.Text;
                RecommendationList.ItemsSource = UserVM.Users.Where(i => i.Name.ToLower().Contains(keyword.ToLower()));
            }
            else if(companiesButton.IsEnabled == false)
            {
                var keyword = RecoSearchBar.Text;
                RecommendationList.ItemsSource = EnterpriseVM.Enterprises.Where(i => i.Name.ToLower().Contains(keyword.ToLower()));
            }
           
        }
    }
}