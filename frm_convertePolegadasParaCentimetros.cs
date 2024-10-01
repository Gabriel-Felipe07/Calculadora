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
    public partial class frm_convertePolegadasParaCentimetros : Form
    {
        public frm_convertePolegadasParaCentimetros()
        {
            InitializeComponent();
        }

        private void button_converter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_polegadas.Text, out double polegadas))
            {
                double centimetros = polegadas * 2.54;
                string stringPronta = $"{Convert.ToString(centimetros)}cm";
                textBox_valor_convertido.Text = stringPronta;
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
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
