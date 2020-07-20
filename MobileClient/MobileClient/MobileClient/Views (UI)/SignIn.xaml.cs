using System;
using MobileClient.Model__Logic_;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CookTime.Model__Logic_;
using CookTime.ViewModel__Abstract_UI_;

namespace MobileClient.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignIn : ContentPage
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private async void btnSignIn_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbEmail.Text) && !string.IsNullOrWhiteSpace(txbUsername.Text) && 
                !string.IsNullOrWhiteSpace(txbPassword.Text) && !string.IsNullOrWhiteSpace(txbPasswordConfrmation.Text))
            {
                if (txbPassword.Text == txbPasswordConfrmation.Text)
                {
                    User user = new User(txbEmail.Text, txbPassword.Text, txbUsername.Text, Int32.Parse(txbAge.Text));
                    var registerjson = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                    var content = new StringContent(registerjson, Encoding.UTF8, "application/json");
                    
                    
                    
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("http://192.168.100.11:8080/CookTimeServer/user/create?info=" + registerjson);
                    
                    HttpResponseMessage response = await client.PutAsync(client.BaseAddress, content);
                    Console.Out.Write(response.StatusCode.ToString());
                    if (response.ReasonPhrase.Equals("OK"))
                    {
                        await DisplayAlert("Alright!", "Everything is setted up for you, go in and take a look!", "Go in!");
                        Client.getInstance().setUser(user);
                        await this.Navigation.PushModalAsync(new MainPage());
                    }
                    else
                    {
                        await DisplayAlert("Oh Oh!",response.StatusCode.ToString() + "\n" + response.ReasonPhrase, ":(");
                    }
                }
                else
                {
                    await DisplayAlert("Wait a minute compa!", "The passwords don't match, go back and check them", "OK");
                }
            }
            else
            {
                await DisplayAlert("Not that fast", "You have to complete all the blanks, go back and complete them", "OK");
            }
        }
    }
}