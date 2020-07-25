using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
using MobileClient.ViewModel__Abstract_UI_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookTime.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserInfo : ContentPage
    {
        UserMenuVM vM;
        private string correo;

        public UserInfo(string name, string image, String email)
        {
            this.correo = email;
            InitializeComponent();
            vM = new UserMenuVM();
            userName.Text = name;
            userImage.Source = image;
            MyMenuList.ItemsSource = vM.getUserMenuIL();
        }

        private async void btnFollow_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/followers?email=" + this.correo + "&newFollower=" + Client.getInstance().getUser().email + "&isUser=true");
                var content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);
                Console.Out.Write(response.StatusCode.ToString());
                if (response.ReasonPhrase.Equals("Accepted"))
                {
                    btnFollow.Text = "User Followed!";
                    btnFollow.IsEnabled = false;
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

        private async void MyMenuList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await this.Navigation.PushModalAsync(new PostInfo(details));
        }
    }
}