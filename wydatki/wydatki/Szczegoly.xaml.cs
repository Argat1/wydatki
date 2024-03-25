using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wydatki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Szczegoly : ContentPage
    {
        Wydatek wydatek;
        public Szczegoly(Wydatek wydatek)
        {
            InitializeComponent();

            this.wydatek = wydatek;
            Display();

        }

        public void Display()
        {
            List<Wydatek> list = new List<Wydatek>();
            list.Add(this.wydatek);
            Lista.ItemsSource = list;
        }
    }
}