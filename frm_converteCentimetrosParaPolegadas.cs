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
    public partial class frm_converteCentimetrosParaPolegadas : Form
    {
        public frm_converteCentimetrosParaPolegadas()
        {
            InitializeComponent();
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

        private void button_converter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_centimetros.Text, out double centimetros))
            {
                double conta = centimetros / 2.54;
                string stringPronta = $"{Convert.ToString(conta)}IN";
                textBox_valor_convertido.Text = stringPronta;
            }
            else
            {
                MessageBox.Show("Digite um valor válido");
            }
        }
    }
}
