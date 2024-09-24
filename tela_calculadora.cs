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
    public partial class tela_calculadora : Form
    {
        public tela_calculadora()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        private void bt_soma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textbox_resultado.Text);
            textbox_resultado.Text = "";
        }

        private void bt_ponto_Click(object sender, EventArgs e)
        {
            if (textbox_resultado.Text.Contains(","))
            {
                textbox_resultado.Text += ",";
            }
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textbox_resultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textbox_resultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textbox_resultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textbox_resultado.Text);
                    break;
            }
            textbox_resultado.Text = Convert.ToString(Resultado);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text = "";
        }
    }
}
