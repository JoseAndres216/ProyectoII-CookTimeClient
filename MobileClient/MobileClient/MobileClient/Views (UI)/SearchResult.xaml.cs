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
    public partial class SearchResult : ContentPage
    {
        public SearchResult()
        {
            InitializeComponent();
            pckType.Items.Add("Users");
            pckType.Items.Add("Enterprises");
            pckType.Items.Add("Recipes");

            pckType.Items.Add("Rating");
            pckType.Items.Add("Difficulty");
            pckType.Items.Add("Duration");
        }

        private void pckType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelected = pckType.SelectedItem.ToString();
            if (itemSelected == "Users" || itemSelected == "Enterprises") 
            {

                pckFilter.SelectedItem = "Rating";
                pckFilter.IsEnabled = false;
            } else
            {
                pckFilter.IsEnabled = true;
            }
        }
    }
}