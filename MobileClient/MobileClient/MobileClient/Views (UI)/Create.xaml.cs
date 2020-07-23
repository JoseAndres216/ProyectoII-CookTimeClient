using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileClient.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
            pckDishType.Items.Add("Starter");
            pckDishType.Items.Add("Main");
            pckDishType.Items.Add("Dessert");
            pckDishType.Items.Add("Drink");
            pckDishType.Items.Add("Other");

            pckTimeofday.Items.Add("Breakfast");
            pckTimeofday.Items.Add("Lunch");
            pckTimeofday.Items.Add("Dinner");
            pckTimeofday.Items.Add("Brunch");
            pckTimeofday.Items.Add("Other");

            pckDifficulty.Items.Add("1");
            pckDifficulty.Items.Add("2");
            pckDifficulty.Items.Add("3");
            pckDifficulty.Items.Add("4");
            pckDifficulty.Items.Add("5");
            pckDifficulty.Items.Add("6");
            pckDifficulty.Items.Add("7");
            pckDifficulty.Items.Add("8");
            pckDifficulty.Items.Add("9");
            pckDifficulty.Items.Add("10");
        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txbRecipeName.Text) && !String.IsNullOrEmpty(txbEstimatedTime.Text) && !String.IsNullOrEmpty(txbServings.Text) && !String.IsNullOrEmpty(pckDishType.SelectedItem.ToString()) && !String.IsNullOrEmpty(pckTimeofday.SelectedItem.ToString()) && !String.IsNullOrEmpty(pckDifficulty.SelectedItem.ToString()) && !String.IsNullOrEmpty(txbIngredients.Text) && !String.IsNullOrEmpty(txbPreparation.Text))
            {
                Recipe newRecipe = new Recipe(txbRecipeName.Text, Client.getInstance().getUser().name, pckTimeofday.SelectedItem.ToString(), int.Parse(txbServings.Text), float.Parse(txbEstimatedTime.Text), pckDishType.SelectedItem.ToString(), int.Parse(pckDifficulty.SelectedItem.ToString()), txbTags.Text, txbIngredients.Text, txbPreparation.Text, int.Parse(txbPrice.Text), float.Parse("0"), 0);
                var registerjson = Newtonsoft.Json.JsonConvert.SerializeObject(newRecipe);
                var content = new StringContent(registerjson, Encoding.UTF8, "application/json");


                HttpClient client = new HttpClient();

                //Hay que revisar esta direccion del API @Eduardo
                client.BaseAddress = new Uri("http://192.168.100.11:8080/CookTimeServer/user/recipe/recipe/?info=" + registerjson);

                HttpResponseMessage response = await client.PutAsync(client.BaseAddress, content);
                Console.Out.Write(response.StatusCode.ToString());
                if (response.ReasonPhrase.Equals("OK"))
                {
                    await DisplayAlert("Alright!", "Your recipe has been created!", "Got ya");
                    await this.Navigation.PushModalAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Oh Oh!", response.StatusCode.ToString() + "\n" + response.ReasonPhrase, ":(");
                }
            }
            else
            {
                await DisplayAlert("Not that fast", "You have to complete all the blanks, go back and complete them", "OK");
            }
        }

        private async void btnPicture_Clicked(object sender, EventArgs e)
        {
            Recipe newRecipe = new Recipe(txbRecipeName.Text, Client.getInstance().getUser().name, pckTimeofday.SelectedItem.ToString(), int.Parse(txbServings.Text), float.Parse(txbEstimatedTime.Text), pckDishType.SelectedItem.ToString(), int.Parse(pckDifficulty.SelectedItem.ToString()), txbTags.Text, txbIngredients.Text, txbPreparation.Text, int.Parse(txbPrice.Text), float.Parse("0"), 0);
            var registerjson = Newtonsoft.Json.JsonConvert.SerializeObject(newRecipe);
            var content = new StringContent(registerjson, Encoding.UTF8, "application/json");

            DisplayAlert("Lo logro?", registerjson, "IDK");
        }
    }
}