using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace wydatki
{
    public partial class App : Application
    {
         static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "baza.txt");

        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
