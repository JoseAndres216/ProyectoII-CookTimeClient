using MobileClient.ViewModel__Abstract_UI_;
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
    public partial class Search : ContentPage
    {
        RecipeVM vM;
        public Search()
        {
            InitializeComponent();
            vM = new RecipeVM();
            RecommendationList.ItemsSource = vM.Posts;
        }
    }
}