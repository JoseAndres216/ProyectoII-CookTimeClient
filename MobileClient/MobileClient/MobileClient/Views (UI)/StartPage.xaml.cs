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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnSignin_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new SignIn());
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LogIn());
        }
    }
}