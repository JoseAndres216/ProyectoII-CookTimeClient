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
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}