﻿using System;
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
    public partial class frm_convetFahrenheitToCelsius : Form
    {
        public frm_convetFahrenheitToCelsius()
        {
            InitializeComponent();
        }

        private void button_converter_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox_fahrenheit.Text, out decimal fahrenheit))
            {
                textBox_fahrenheit.Text = textBox_fahrenheit.Text + " °F";
                decimal celsius = (fahrenheit - 32) * 5 / 9;
                string stringPronta = $"{Convert.ToString(celsius)} °C";
                textBox_valor_convertido.Text = stringPronta;
            }
            else
            {
                MessageBox.Show("Digite um valor válido");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_calculadora janela_calculadora = new tela_calculadora();
            this.Hide();
            janela_calculadora.ShowDialog();
        }
    }
}
