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
    public partial class GangsPage : ContentPage
    {
        public GangsPage()
        {
            InitializeComponent();
        }

        private void CreateGangBtn_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new AddGangPage())
            {
                BarBackgroundColor = Color.Black
            };
        }

        protected override void OnAppearing()
        {
            GangsList.ItemsSource = App.DataBase.GetStreets();
            base.OnAppearing();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new AboutGangPage())
            {
                BarBackgroundColor = Color.Black
            };
        }
    }
}