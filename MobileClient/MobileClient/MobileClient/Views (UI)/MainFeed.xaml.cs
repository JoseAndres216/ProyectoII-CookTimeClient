using CookTime.ViewModel__Abstract_UI_;
using CookTime.Views__UI_;
using MobileClient.Model__Logic_;
using MobileClient.ViewModel__Abstract_UI_;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClient.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainFeed : ContentPage
    {
        RecipeVM vM;
        public MainFeed()
        {
            InitializeComponent();
            vM = new RecipeVM();
            ListPosts.ItemsSource = Client.getInstance().getFeedIL();
        }
        /*
         * updates the list view with updated recipes 
         */
        public void update()
        {
           ListPosts.ItemsSource = Client.getInstance().getFeedIL();
        }

        private async void itemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await this.Navigation.PushModalAsync(new PostInfo(details.getName(), details.getUser(), details.getType(), details.getServings(), details.getDuration().ToString(),
                details.getTiming(), details.getDifficulty().ToString(), details.getTags(), details.getIngredients(), details.getSteps(), details.getPrice(), details.getImage()));
        }

        private void ListPosts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}