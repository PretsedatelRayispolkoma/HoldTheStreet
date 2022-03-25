using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UlicuDerjiApp.Pages;
using UlicuDerjiApp.SQLConnection;
using System.IO;

namespace UlicuDerjiApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "holdthestreet.db";
        
        private static SQLDB _database;

        public static SQLDB DataBase
        {
            get
            {
                if (_database == null)
                {
                    _database = new SQLDB(Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AuthPage())
            {
                BarBackgroundColor = Color.Black
            };

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
