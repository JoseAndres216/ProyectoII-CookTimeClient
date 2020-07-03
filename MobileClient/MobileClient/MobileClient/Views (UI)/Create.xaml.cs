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
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
            pckDishType.Items.Add("Starter");
            pckDishType.Items.Add("Main");
            pckDishType.Items.Add("Dessert");
            pckDishType.Items.Add("Drink");
            pckDishType.Items.Add("Other");

            pckTimeofday.Items.Add("Breakfast");
            pckTimeofday.Items.Add("Lunch");
            pckTimeofday.Items.Add("Dinner");
            pckTimeofday.Items.Add("Brunch");
            pckTimeofday.Items.Add("Other");

            pckDifficulty.Items.Add("Begginer");
            pckDifficulty.Items.Add("Average chef");
            pckDifficulty.Items.Add("Master Chef Costa Rica");
        }
    }
}