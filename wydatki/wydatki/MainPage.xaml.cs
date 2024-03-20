using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace wydatki
{
    public partial class MainPage : TabbedPage
    {

        string path = App.pathtxt;
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
            if(File.Exists(App.pathtxt))
            {
                string odczytane = File.ReadAllText(App.pathtxt);
                string zapis = odczytane + NazwaTxt.Text + KwotaTxt.Text + DataTxt.Date.ToString();
                File.WriteAllText(App.pathtxt, zapis);
            }
            else
            {
                File.WriteAllText(App.pathtxt, NazwaTxt.Text + KwotaTxt.Text + DataTxt.Date.ToString());
            }
        }
        public async void Sczegoly(object sender, EventArgs e)
        {
            
        }
    }
}
