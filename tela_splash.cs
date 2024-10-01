namespace Calculadora
{
    public partial class tela_splash : Form
    {
        tela_calculadora telaCalculadora = new tela_calculadora();
        string caminho = @"C:\Users\aluno\Desktop\Calculadora\frases_de_carregamento\frases.txt";
        StreamReader leitor;

        public tela_splash()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leitor = new StreamReader(caminho);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
            {
                progressBar1.Value += 10;
                string conteudo = leitor.ReadLine();
                lbl_frases_carregamento.Text = conteudo;

            }
            else if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                telaCalculadora.Show();
                this.Hide();
            }




        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            leitor.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tela_splash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Verifica se a tecla pressionada é Enter
            {
                progressBar1.Value = 100; // Define o valor da ProgressBar como 100
                timer1_Tick(sender, e); // Chama o método para finalizar a tela de splash
            }
        }
    }
}
