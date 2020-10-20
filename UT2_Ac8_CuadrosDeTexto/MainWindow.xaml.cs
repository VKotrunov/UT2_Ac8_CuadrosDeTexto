using System;
using System.Windows;
using System.Windows.Input;


namespace UT2_Ac8_CuadrosDeTexto
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void edadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2) {
                bool verificacion = int.TryParse(edadTextBox.Text, out int edad);
                if (!verificacion)
                    edadTextBlock.Text = "Edad incorrecta";
                else
                    edadTextBlock.Text = "";
            }
        }

        private void nombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && nombreTextBlock.Text == "")
            {
                nombreTextBlock.Text = "Nombre del cliente";
            }
            else
                nombreTextBlock.Text = "";
        }

        private void apellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1 && apellidoTextBlock.Text == "")
            {
                apellidoTextBlock.Text = "Apellido del cliente";
            }
            else
                apellidoTextBlock.Text = "";
        }
    }
}
