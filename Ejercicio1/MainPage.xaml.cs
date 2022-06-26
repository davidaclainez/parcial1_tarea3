using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSumar_Clicked(object sender, EventArgs e)
        {
            var respuesta = Convert.ToInt32(firtNumber.Text) + Convert.ToInt32(secondNumber.Text);
            await Navigation.PushAsync(new SecondPage(respuesta));
        }

        private async void btnRestar_Clicked(object sender, EventArgs e)
        {
            var respuesta = Convert.ToInt32(firtNumber.Text) - Convert.ToInt32(secondNumber.Text);
            await Navigation.PushAsync(new SecondPage(respuesta));
        }

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            var respuesta = Convert.ToInt32(firtNumber.Text) * Convert.ToInt32(secondNumber.Text);
            await Navigation.PushAsync(new SecondPage(respuesta));
        }

        private async void btnDividir_Clicked(object sender, EventArgs e)
        {
            var respuesta = Convert.ToInt32(firtNumber.Text) / Convert.ToInt32(secondNumber.Text);
            await Navigation.PushAsync(new SecondPage(respuesta));
        }
    }
}
