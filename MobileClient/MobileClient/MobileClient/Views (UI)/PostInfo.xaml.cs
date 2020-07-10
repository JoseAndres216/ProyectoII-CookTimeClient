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
    public partial class PostInfo : ContentPage
    {
        public PostInfo(string name, string user, string type, int servings, string duration, string timing, string difficulty,
            string tags, string ingredients, string steps, int price, string image)
        {
            InitializeComponent();
            postName.Text = name;
            postUser.Text = "- By: " + user;
            postType.Text = "- Type: " + type;
            postServings.Text = "- It serves for " + servings + " people";
            postDuration.Text = "- It takes: " + duration;
            postTiming.Text = "- Its a " + timing;
            postDifficulty.Text = "- From one to ten this is a: " + difficulty;
            postTags.Text = "- Tags: " + tags;
            postIngredients.Text = "- You'll need: \n" + ingredients;
            postSteps.Text = "- Steps: \n" + steps;
            postPrice.Text = "- Suggested price $ " + price;
            postImage.Source = new UriImageSource()
            {
                Uri = new Uri(image)
            };

            pckQuilification.Items.Add("   1");
            pckQuilification.Items.Add("   2");
            pckQuilification.Items.Add("   3");
            pckQuilification.Items.Add("   4");
            pckQuilification.Items.Add("   5");
            pckQuilification.Items.Add("   6");
            pckQuilification.Items.Add("   7");
            pckQuilification.Items.Add("   8");
            pckQuilification.Items.Add("   9");
            pckQuilification.Items.Add("   10");

            pckQuilification.SelectedItem = "Qualification";
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }

        private void btnShare_Clicked(object sender, EventArgs e)
        {
            btnShare.Text = "Shared!";
            btnShare.IsEnabled = false;
        }

        private async void btnQualify_Clicked(object sender, EventArgs e)
        {
            if (pckQuilification.SelectedItem.ToString() != "Qualification")
            {
                btnQualify.Text = "Thanks!";
                btnQualify.IsEnabled = false;
                pckQuilification.IsEnabled = false;
            }
            else
            {
                await DisplayAlert("Ups...", "You have to choose a qualification first, go back, select it and touch the qualify button", "OK");
            }
        }

        private void btnComment_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSeeComentaries_Clicked(object sender, EventArgs e)
        {

        }
    }
}