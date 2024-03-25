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
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace wydatki
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        List<Wydatek> expensesList = new List<Wydatek>();

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
       3{

            List<string> strings = File.ReadAllLines(path).ToList();
            List<Wydatek> expenses = new List<Wydatek>();
            Wydatek expense = new Wydatek();
            

            foreach (var item in strings)
            {
                string[] substring = item.Split(';');
                expense.nazwa = substring[0];
                expense.kwota = decimal.Parse(substring[1]);
                expense.data = DateTime.Parse(substring[2]);
                expenses.Add(expense);
            }

            Lista.ItemsSource = expenses;

        }
        public async void DodajWydatek(object sender, EventArgs e)
        {
            /*if(File.Exists(App.pathtxt))
            {
                string odczytane = File.ReadAllText(App.pathtxt);
                string zapis = odczytane + NazwaTxt.Text + ":" + KwotaTxt.Text + ":" +  DataTxt.Date.ToString() + ";";
                File.WriteAllText(App.pathtxt, zapis);
            }
            else
            {
                File.WriteAllText(App.pathtxt, NazwaTxt.Text + ":" + KwotaTxt.Text + ":" + DataTxt.Date.ToString() + ";");
            }*/

            Wydatek expense = new Wydatek();
            if (string.IsNullOrEmpty(NazwaTxt.Text))
            {
                expense.data = DataTxt.Date;
                expense.nazwa = "Brak tytulu";
                expense.kwota = decimal.Parse(KwotaTxt.Text);
            }
            else
            {
                expense.data = DataTxt.Date;
                expense.nazwa = NazwaTxt.Text;
                expense.kwota = decimal.Parse(KwotaTxt.Text);
            }

            expensesList.Add(expense);

            if (File.Exists(App.pathtxt))
            {
                List<string> stringsOld = File.ReadAllLines(path).ToList();
                List<Wydatek> expenses = new List<Wydatek>();
                Wydatek expenseOld = new Wydatek();
                List<string> strings = new List<string>();
                foreach (var item in stringsOld)
                {
                    string[] substring = item.Split(';');
                    expenseOld.nazwa = substring[0];
                    expenseOld.kwota = decimal.Parse(substring[1]);
                    expenseOld.data = DateTime.Parse(substring[2]);
                    strings.Add(expenseOld.nazwa + "; " + expenseOld.kwota + "; " + expenseOld.data + ";");
                    
                }
                
                foreach (var item in expensesList)
                {
                    strings.Add(item.nazwa + "; " + item.kwota + "; " + item.data + ";");
                }
                
                File.WriteAllLines(path, strings);

            }
            else
            {

                List<string> strings = new List<string>();
                foreach (var item in expensesList)
                {
                    strings.Add(item.nazwa + "; " + item.kwota + "; " + item.data);
                }
                File.WriteAllLines(path, strings);
            }



            wyswietl();
            DisplayAlert("Informacja", "Pomyślnie dodano wydatek", "OK");
            NazwaTxt.Text = KwotaTxt.Text = String.Empty;
        }
        public async void Sczegoly(object sender, EventArgs e)
        {
            Wydatek expense = (Wydatek)Lista.SelectedItem;

            if (expense == null)
            {
                DisplayAlert("Błąd", "Wybierz element z listy", "OK");
            }
            Navigation.PushAsync(new Szczegoly(expense));

        }
    }
}
