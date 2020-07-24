using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookTime.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostInfo : ContentPage
    {
        public Recipe recipe;
        public PostInfo(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            postName.Text = recipe.name;
            postUser.Text = "- By: " + recipe.author;
            postType.Text = "- Type: " + recipe.type;
            postServings.Text = "- It serves for " + recipe.servings + " people";
            postDuration.Text = "- It takes: " + recipe.duration;
            postTiming.Text = "- Its a " + recipe.timing;
            postDifficulty.Text = "- From one to ten this is a: " + recipe.difficulty;
            postTags.Text = "- Tags: " + recipe.tags;
            postIngredients.Text = "- You'll need: \n" + recipe.ingredients;
            postSteps.Text = "- Steps: \n" + recipe.steps;
            postPrice.Text = "- Suggested price $ " + recipe.price;
            postImage.Source = recipe.image;

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

        private async void btnShare_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/recipe/share?recipe=" + this.recipe.name + "&user=" + Client.getInstance().getUser().email);
                var content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);
                Console.Out.Write(response.StatusCode.ToString());
                if (response.ReasonPhrase.Equals("Accepted"))
                {
                    btnShare.Text = "Shared!";
                    btnShare.IsEnabled = false;
                }
                else
                {
                    await DisplayAlert("Error", response.ReasonPhrase, "OK");
                }
            }
            catch
            {
                await DisplayAlert("Error", "Something went wrong", "OK");
            }


        }

        private async void btnQualify_Clicked(object sender, EventArgs e)
        {
            try
            {
                int rate;
                if (pckQuilification.SelectedItem.ToString() != "Qualification")
                {
                    rate = Int16.Parse(pckQuilification.SelectedItem.ToString());
                   

                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/recipe/like?recipe=" + this.recipe.name + "&user=" + Client.getInstance().getUser().email);
                    var content = new StringContent("", Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);
                    Console.Out.Write(response.StatusCode.ToString());
                    if (response.ReasonPhrase.Equals("Accepted"))
                    {
                        btnQualify.Text = "Thanks!";
                        btnQualify.IsEnabled = false;
                        pckQuilification.IsEnabled = false;
                    }
                    else
                    {
                        await DisplayAlert("Error", response.ReasonPhrase, "OK");
                    }
                }
                else
                {
                    await DisplayAlert("Ups...", "You have to choose a qualification first, go back, select it and touch the qualify button", "OK");
                }
                
            }
            catch
            {
                await DisplayAlert("Error", "Something went wrong", "OK");
            }


        }


        private void btnSeeComentaries_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new CommentSection(recipe));
        }
    }
}