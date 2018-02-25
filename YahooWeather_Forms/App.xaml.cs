﻿using Xamarin.Forms;

namespace YahooWeather_Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new YahooWeather_FormsPage();
            MainPage = new NavigationPage(new YahooWeather_FormsPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
