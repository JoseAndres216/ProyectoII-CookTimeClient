using CookTime.Model__Logic_;
using CookTime.ViewModel__Abstract_UI_;
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
            if (!string.IsNullOrWhiteSpace(txbUsername.Text) && !string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                User user = new User(); //Aqui hay que igualar al usuario que se deserializa del Json
                Client.getInstance().setUser(user);
                await Navigation.PushModalAsync(new MainPage());

            }
            else
            {
                await DisplayAlert("Not that fast", "You have to complete all the blanks, go back and complete them", "OK");
            }
        }
    }
}
