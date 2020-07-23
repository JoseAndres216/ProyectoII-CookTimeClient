using CookTime.Model__Logic_;
using CookTime.Model__Logic_.Data_Structures;
using CookTime.ViewModel__Abstract_UI_;
using MobileClient.Model__Logic_;
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
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                bool exit = await this.DisplayAlert("Wait!", "You are going to close the app, are you sure?", "Yes", "No");
                if (exit)
                {
                    System.Environment.Exit(0);
                }
            });
            return true;
        }

        private void btnPass_Clicked(object sender, EventArgs e)
        {
            User user = new User("Prueba1234", "pass", "Prueba12345", 21);
            Client.getInstance().setUser(user);
            Client.getInstance().getUser().newsFeed = new CookTime.Model__Logic_.Data_Structures.Stack<Recipe>();
            Client.getInstance().getUser().newsFeed.setElements(new SimpleList<Recipe>());
            Client.getInstance().getUser().newsFeed.getElements().setHead(new Node<Recipe>(new Recipe("Usuario", "Receta")));
            Client.getInstance().getUser().notifications = new CookTime.Model__Logic_.Data_Structures.Stack<string>();
            Client.getInstance().getUser().notifications.setElements(new SimpleList<string>());
            Client.getInstance().getUser().notifications.getElements().setHead(new Node<String>("Ejemplo de notificacion"));
            Client.getInstance().getUser().MyMenu = new MyMenu();
            Client.getInstance().getUser().MyMenu.setOwnedrecipes(new SimpleList<Recipe>());
            Client.getInstance().getUser().MyMenu.getOwnedrecipes().setHead(new Node<Recipe>(new Recipe("Usuario", "Receta")));
            Client.getInstance().isUser = true;
            this.Navigation.PushModalAsync(new MainPage());
        }
    }
}