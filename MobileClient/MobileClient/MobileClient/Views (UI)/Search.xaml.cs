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
            RecommendationList.ItemsSource = Client.getInstance().getFeedIL();
            BindingContext = RecommendationList;
            
            recipesButton.IsEnabled = false;
            usersButton.IsEnabled = true;
            companiesButton.IsEnabled = true;

        }

        private void RecommendationList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            this.Navigation.PushModalAsync(new PostInfo(details.getName(), details.getUser(), details.getType(), details.getServings(), details.getDuration().ToString(),
                details.getTiming(), details.getDifficulty().ToString(), details.getTags(), details.getIngredients(), details.getSteps(), details.getPrice(), details.getImage()));
        }

        private void recipesButton_Clicked(object sender, EventArgs e)
        {
            RecommendationList.ItemsSource = Client.getInstance().getFeedIL();

            recipesButton.IsEnabled = false;
            usersButton.IsEnabled = true;
            companiesButton.IsEnabled = true;
        }

        private void usersButton_Clicked(object sender, EventArgs e)
        {
            RecommendationList.ItemsSource = null;
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
                RecommendationList.ItemsSource = Client.getInstance().getFeedIL().Where(i => i.getName().ToLower().Contains(keyword.ToLower()));
            }
            else if(usersButton.IsEnabled == false)
            {
                var keyword = RecoSearchBar.Text;
             RecommendationList.ItemsSource = UserVM.Users.Where(i => i.getName().ToLower().Contains(keyword.ToLower()));
            }
            else if(companiesButton.IsEnabled == false)
            {
                var keyword = RecoSearchBar.Text;
                RecommendationList.ItemsSource = EnterpriseVM.Enterprises.Where(i => i.Name.ToLower().Contains(keyword.ToLower()));
            }
           
        }

        private async void RecoSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new SearchResult());
        }
    }
}