using System;
using Xamarin.Forms;

namespace CalculadoraBasica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);
                res.Text = (a + b).ToString();
                DisplayAlert("✔ Resultado", "El Resultado es: " + res.Text, "OK");
            }
            else
            {
                DisplayAlert("❌ Datos Vacíos", "Digite los Valores", "OK");
            }
        }

        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);
                res.Text = (a - b).ToString();
                DisplayAlert("✔ Resultado", "El Resultado es: " + res.Text, "OK");
            }
            else
            {
                DisplayAlert("❌ Datos Vacíos", "Digite los Valores", "OK");
            }
        }

        private void BtnMul_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);
                res.Text = (a * b).ToString();
                DisplayAlert("✔ Resultado", "El Resultado es: " + res.Text, "OK");
            }
            else
            {
                DisplayAlert("❌ Datos Vacíos", "Digite los Valores", "OK");
            }
        }

        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);
                if (b != 0)
                {
                    res.Text = (a / b).ToString();
                    DisplayAlert("✔ Resultado", "El Resultado es: " + res.Text, "OK");
                }
                else
                {
                    DisplayAlert("❌ Error", "No se puede dividir por cero", "OK");
                }
            }
            else
            {
                DisplayAlert("❌ Datos Vacíos", "Digite los Valores", "OK");
            }
        }

        private void BtnRem_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num2.Text))
            {
                var a = double.Parse(num1.Text);
                var b = double.Parse(num2.Text);
                res.Text = (a % b).ToString();
                DisplayAlert("✔ Resultado", "El Resultado es: " + res.Text, "OK");
            }
            else
            {
                DisplayAlert("❌ Datos Vacíos", "Digite los Valores", "OK");
            }
        }

        private void BtnClr_Clicked(object sender, EventArgs e)
        {
            num1.Text = String.Empty;
            num2.Text = String.Empty;
            res.Text = String.Empty;
        }
    }
}
