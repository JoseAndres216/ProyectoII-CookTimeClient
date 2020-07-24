using MobileClient.Model__Logic_;
using MobileClient.ViewModel__Abstract_UI_;
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
    public partial class UserInfo : ContentPage
    {
        UserMenuVM vM;
        public UserInfo(string name, string image)
        {
            InitializeComponent();
            vM = new UserMenuVM();
            userName.Text = name;
            userImage.Source = image;
            MyMenuList.ItemsSource = vM.getUserMenuIL();
        }

        private void btnFollow_Clicked(object sender, EventArgs e)
        {

        }

        private async void MyMenuList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Recipe;
            await this.Navigation.PushModalAsync(new PostInfo(details));
        }
    }
}