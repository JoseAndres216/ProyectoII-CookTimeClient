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
        public PostInfo(string name, string user, string type, string duration, string difficulty, string ingredients,
            string steps, string imagesource)
        {
            InitializeComponent();
            postName.Text = name;
            postUser.Text = "By: " + user;
            postType.Text = "Type: " + type;
            postDuration.Text = "It takes: " + duration;
            postDifficulty.Text = "From one to ten this is a: " + difficulty;
            postIngredients.Text = "You'll need: \n" + ingredients;
            postSteps.Text = "Steps: \n" + steps; 
            postImage.Source = new UriImageSource()
            {
                Uri = new Uri(imagesource)
            };
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}