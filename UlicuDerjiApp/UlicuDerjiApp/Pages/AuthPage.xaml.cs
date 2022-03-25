using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UlicuDerjiApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegPage());
        }

        private void SignInBtn_Clicked(object sender, EventArgs e)
        {
            var user = App.DataBase.GetUsers().Where(u => u.Login == LoginEntry.Text && u.Password == PasswordEntry.Text);
            if (user != null)
            {
                Application.Current.MainPage = new NavigationPage(new GangsPage())
                {
                    BarBackgroundColor = Color.Gray
                };
            }        
            else
            {
                DisplayAlert("Error", "Incorrect login or password", "OK");
            }
        }
    }
}