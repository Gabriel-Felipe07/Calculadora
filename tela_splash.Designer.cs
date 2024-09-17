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
            progressBar1 = new ProgressBar();
            lbl_frases_carregamento = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 210);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(758, 23);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 100;
            // 
            // lbl_frases_carregamento
            // 
            lbl_frases_carregamento.AutoSize = true;
            lbl_frases_carregamento.Location = new Point(204, 178);
            lbl_frases_carregamento.Name = "lbl_frases_carregamento";
            lbl_frases_carregamento.Size = new Size(78, 15);
            lbl_frases_carregamento.TabIndex = 1;
            lbl_frases_carregamento.Text = "Carregando...";
            // 
            // tela_splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_frases_carregamento);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "tela_splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lbl_frases_carregamento;
    }
}
