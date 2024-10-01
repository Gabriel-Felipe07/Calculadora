using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frm_convertCelsiusToFahrenheit : Form
    {
        public frm_convertCelsiusToFahrenheit()
        {
            InitializeComponent();
        }

        private void button_converter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox_celsius.Text, out decimal celsius))
            {
                decimal fahrenheit = (celsius * 9 / 5) + 32;

                string stringPronta = ($"{Convert.ToString(fahrenheit)}°F");

                textBox_fahrenheit.Text = stringPronta;
            }
            else
            {
                MessageBox.Show("Digite um valor válido");
            }
        }
    }
}
