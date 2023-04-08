using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfCalculadora
{
    public partial class MainWindow : Window
    {
        private string operador = string.Empty;
        private double numero1 = 0;
        private double numero2 = 0;
        private double resultado = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string nuevoNumero = button.Content.ToString();

            if (lblPantalla.Content.ToString() == "0")
            {
                lblPantalla.Content = nuevoNumero;
            }
            else
            {
                lblPantalla.Content += nuevoNumero;
            }
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            numero2 = Convert.ToDouble(lblPantalla.Content);

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    break;
            }

            lblPantalla.Content = resultado.ToString();
            operador = string.Empty;
        }

        private void btnOperador_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operador = button.Content.ToString();
            numero1 = Convert.ToDouble(lblPantalla.Content);
            lblPantalla.Content = "0";
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            lblPantalla.Content = "0";
            operador = string.Empty;
            numero1 = 0;
            numero2 = 0;
            resultado = 0;
        }
    }
}
