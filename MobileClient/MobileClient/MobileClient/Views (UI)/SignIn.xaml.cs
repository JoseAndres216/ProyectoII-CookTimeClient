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
                    await DisplayAlert("Alright!", "Everithing is setted up for you, go in and take a look!", "Go in!");
                    await this.Navigation.PushModalAsync(new MainPage());
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