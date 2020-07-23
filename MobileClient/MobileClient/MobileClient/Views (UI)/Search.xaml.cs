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
        public Search()
        {
            InitializeComponent();
            vM = new RecipeVM();
            RecommendationList.ItemsSource = vM.Posts;
        }

        private void RecommendationList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            this.Navigation.PushModalAsync(new PostInfo(details.Name, details.User, details.Type, details.Servings, details.Duration,
                details.Timing, details.Difficulty, details.Tags, details.Ingredients, details.Steps, details.Price, details.Image));
        }

        private void recipesButton_Clicked(object sender, EventArgs e)
        {

        }

        private void usersButton_Clicked(object sender, EventArgs e)
        {

        }

        private void companiesButton_Clicked(object sender, EventArgs e)
        {

        }
        private void searchButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SearchPage());
        }
    }
}