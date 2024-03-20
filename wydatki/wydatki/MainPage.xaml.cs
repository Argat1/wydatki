using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wydatki
{
    public partial class MainPage : TabbedPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            wyswietl();
        }
        private void wyswietl()
        {
            
            
        }
        public async void DodajWydatek(object sender, EventArgs e)
        {
            
        }
        public async void Sczegoly(object sender, EventArgs e)
        {
            
        }
    }
}
