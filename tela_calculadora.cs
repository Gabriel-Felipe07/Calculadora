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
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public tela_calculadora()
        {
            InitializeComponent();
        }
        private void bt_0_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textbox_resultado.Text += "9";
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textbox_resultado.Text);
            textbox_resultado.Text = "";
        }

        private void bt_subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textbox_resultado.Text);
            textbox_resultado.Text = "";
        }

        private void bt_multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textbox_resultado.Text);
            textbox_resultado.Text = "";
        }

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

        private void tela_calculadora_Load(object sender, EventArgs e)
        {

        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_convertCelsiusToFahrenheit janelaConversaoParaFahrenheit = new frm_convertCelsiusToFahrenheit();
            this.Hide();
            janelaConversaoParaFahrenheit.ShowDialog();
        }
    }
}
