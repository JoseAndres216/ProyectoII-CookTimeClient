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
            ListPosts.ItemsSource = vM.Posts;
        }
        private async void itemSelected(Object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await this.Navigation.PushModalAsync(new PostInfo(details.Name, details.User, details.Type, details.Servings, details.Duration,
                details.Timing, details.Difficulty, details.Tags, details.Ingredients, details.Steps, details.Price, details.Image));
        }

        private void ListPosts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}