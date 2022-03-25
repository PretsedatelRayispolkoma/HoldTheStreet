using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlicuDerjiApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UlicuDerjiApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddGangPage : ContentPage
    {
        Street street;

        public AddGangPage()
        {
            InitializeComponent();
        }

        private void AddGangBtn_Clicked(object sender, EventArgs e)
        {
            street = new Street()
            {
                StreetName = GangNameEntry.Text,
                District = NewDistrictEntry.Text,
                Obshyak = Convert.ToDecimal(ObshyakEntry.Text)
            };
            if (!String.IsNullOrEmpty(street.StreetName))
                App.DataBase.SaveStreet(street);
            Application.Current.MainPage = new NavigationPage(new GangsPage())
            {
                BarBackgroundColor = Color.Black
            };
        }

        private void BackButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage( new GangsPage())
            {
                BarBackgroundColor = Color.Black
            };
        }
    }
}