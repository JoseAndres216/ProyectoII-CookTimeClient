using CookTime.Model__Logic_;
using CookTime.ViewModel__Abstract_UI_;
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
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        private async void btnLogIn_Clicked(object sender, EventArgs e)
        {
            string email = txbUsername.Text;
            string password = txbPassword.Text;
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                // User user = new User(); //Aqui hay que igualar al usuario que se deserializa del Json
                // Client.getInstance().setUser(user);

                HttpClient client = new HttpClient();


                //     ?  ---> para decir que van parametros SOLO EL PRIMERO    
                //     &  ---> para separar un parametro de otro. :)
                client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/verify?user=" + email + "&pass=" + password);

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

                //Get the json from the sever NULL if didn't match
                String userJson = response.Content.ReadAsStringAsync().Result;
                //Serialize the json object to a User object and assign it to the Client User
                User newUser = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(userJson);
                Client.getInstance().setUser(newUser);

                Console.WriteLine("Recibed Json: " + userJson);
                Console.WriteLine("Generated user: "+ newUser.ToString());
                 

                await Navigation.PushModalAsync(new MainPage());

            }
            else
            {
                await DisplayAlert("Not that fast", "You have to complete all the blanks, go back and complete them", "OK");
            }
        }
    }
}
