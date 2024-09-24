namespace Calculadora
{
    partial class tela_splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            lbl_frases_carregamento = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 210);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(758, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // lbl_frases_carregamento
            // 
            lbl_frases_carregamento.AutoSize = true;
            lbl_frases_carregamento.Font = new Font("Segoe UI", 10F);
            lbl_frases_carregamento.Location = new Point(121, 168);
            lbl_frases_carregamento.Name = "lbl_frases_carregamento";
            lbl_frases_carregamento.Size = new Size(90, 19);
            lbl_frases_carregamento.TabIndex = 1;
            lbl_frases_carregamento.Text = "Carregando...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.engrenagem;
            pictureBox1.Location = new Point(284, 255);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(273, 48);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 3;
            label1.Text = "Carregando calculadora...";
            // 
            // tela_splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_frases_carregamento);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "tela_splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lbl_frases_carregamento;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
