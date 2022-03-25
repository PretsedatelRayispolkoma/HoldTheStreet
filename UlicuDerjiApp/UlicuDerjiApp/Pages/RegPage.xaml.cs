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
    public partial class RegPage : ContentPage
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private async void SignBtn_Clicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = nameEntry.Text,
                Surname = surnameEntry.Text,
                Login = emailEntry.Text,
                Password = PasswordEntry.Text
        };

            if (nameEntry.Text != null && surnameEntry.Text != null && emailEntry.Text != null
                && PasswordEntry.Text != null && Password2Entry.Text != null)
            {
                
                if (PasswordEntry.Text == Password2Entry.Text)
                {
                    App.DataBase.SaveUser(user);
                    await this.Navigation.PopAsync();
                }
                else
                    await DisplayAlert("Error", "Passwords are not matched", "OK");
            }
            else
            {
                
                await DisplayAlert("Error", "Enter the data", "OK");
            }
        }
    }
}