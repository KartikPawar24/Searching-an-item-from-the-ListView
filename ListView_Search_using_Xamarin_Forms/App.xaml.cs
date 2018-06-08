using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ListView_Search_using_Xamarin_Forms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListView_Search_using_Xamarin_Forms.MainPage();
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
