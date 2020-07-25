using CookTime.Model__Logic_.Data_Structures;
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

namespace CookTime.Views__UI_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentSection : ContentPage
    {
        private Recipe recipe;

        public CommentSection()
        {
            InitializeComponent();

            //comments null
            Node<string> current = recipe.comments.getHead();
            List<string> commentsL = new List<string>();
            while(current != null)
            {
                commentsL.Add(current.getdata());
            }
            CommentsList.ItemsSource = commentsL;
        }

        public CommentSection(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
        }
        public void btnComment_ClickedAsync(object sender, EventArgs e)
        {
            this.btnComment_ClickedAsyncAux(sender, e);
        }
        private async Task btnComment_ClickedAsyncAux(object sender, EventArgs e)
        {
            String comment = txbMessage.Text;
            if (!comment.Equals(string.Empty))
            {
                var content = new StringContent("", Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(Client.HTTP_BASE_URL + "user/recipe/comment" +
                    "?recipe=" + this.recipe.name +
                    "&comment=" + comment +
                    "&user=" + Client.getInstance().getUser().email);

                HttpResponseMessage response = await client.PostAsync(client.BaseAddress, content);
                if (response.ReasonPhrase.Equals("Created")) 
                {
                    await DisplayAlert("Recipe commented", "The comment was published", "OK");
                }
                else
                {
                    await DisplayAlert("Error", response.ToString(), "OK");
                }
            }

        }
    }
}