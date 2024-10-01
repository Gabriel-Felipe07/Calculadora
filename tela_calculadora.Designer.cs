namespace Calculadora
{
    partial class tela_calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_0 = new Button();
            bt_ponto = new Button();
            bt_1 = new Button();
            bt_2 = new Button();
            bt_3 = new Button();
            bt_4 = new Button();
            bt_6 = new Button();
            bt_5 = new Button();
            bt_8 = new Button();
            bt_7 = new Button();
            bt_9 = new Button();
            bt_soma = new Button();
            bt_divisao = new Button();
            bt_subtracao = new Button();
            bt_multiplicacao = new Button();
            bt_igual = new Button();
            textbox_resultado = new TextBox();
            bt_limpar = new Button();
            menuStrip1 = new MenuStrip();
            conversãoToolStripMenuItem = new ToolStripMenuItem();
            celsiusParaFahrenheitToolStripMenuItem = new ToolStripMenuItem();
            fahrenheitParaCelsiusToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_0
            // 
            bt_0.Font = new Font("Microsoft Sans Serif", 16F);
            bt_0.Location = new Point(21, 408);
            bt_0.Name = "bt_0";
            bt_0.Size = new Size(97, 65);
            bt_0.TabIndex = 1;
            bt_0.Text = "0";
            bt_0.UseVisualStyleBackColor = true;
            bt_0.Click += bt_0_Click;
            // 
            // bt_ponto
            // 
            bt_ponto.Font = new Font("Segoe UI", 20F);
            bt_ponto.Location = new Point(124, 408);
            bt_ponto.Name = "bt_ponto";
            bt_ponto.Size = new Size(97, 66);
            bt_ponto.TabIndex = 1;
            bt_ponto.Text = ".";
            bt_ponto.UseVisualStyleBackColor = true;
            bt_ponto.Click += bt_ponto_Click_1;
            // 
            // bt_1
            // 
            bt_1.Font = new Font("Microsoft Sans Serif", 16F);
            bt_1.Location = new Point(21, 337);
            bt_1.Name = "bt_1";
            bt_1.Size = new Size(97, 65);
            bt_1.TabIndex = 1;
            bt_1.Text = "1";
            bt_1.UseVisualStyleBackColor = true;
            bt_1.Click += bt_1_Click;
            // 
            // bt_2
            // 
            bt_2.Font = new Font("Microsoft Sans Serif", 16F);
            bt_2.Location = new Point(124, 337);
            bt_2.Name = "bt_2";
            bt_2.Size = new Size(97, 65);
            bt_2.TabIndex = 1;
            bt_2.Text = "2";
            bt_2.UseVisualStyleBackColor = true;
            bt_2.Click += bt_2_Click;
            // 
            // bt_3
            // 
            bt_3.Font = new Font("Microsoft Sans Serif", 16F);
            bt_3.Location = new Point(227, 337);
            bt_3.Name = "bt_3";
            bt_3.Size = new Size(97, 66);
            bt_3.TabIndex = 1;
            bt_3.Text = "3";
            bt_3.UseVisualStyleBackColor = true;
            bt_3.Click += bt_3_Click;
            // 
            // bt_4
            // 
            bt_4.Font = new Font("Microsoft Sans Serif", 16F);
            bt_4.Location = new Point(21, 265);
            bt_4.Name = "bt_4";
            bt_4.Size = new Size(97, 64);
            bt_4.TabIndex = 1;
            bt_4.Text = "4";
            bt_4.UseVisualStyleBackColor = true;
            bt_4.Click += bt_4_Click;
            // 
            // bt_6
            // 
            bt_6.Font = new Font("Microsoft Sans Serif", 16F);
            bt_6.Location = new Point(227, 265);
            bt_6.Name = "bt_6";
            bt_6.Size = new Size(97, 66);
            bt_6.TabIndex = 1;
            bt_6.Text = "6";
            bt_6.UseVisualStyleBackColor = true;
            bt_6.Click += bt_6_Click;
            // 
            // bt_5
            // 
            bt_5.Font = new Font("Microsoft Sans Serif", 16F);
            bt_5.Location = new Point(124, 265);
            bt_5.Name = "bt_5";
            bt_5.Size = new Size(97, 66);
            bt_5.TabIndex = 1;
            bt_5.Text = "5";
            bt_5.UseVisualStyleBackColor = true;
            bt_5.Click += bt_5_Click;
            // 
            // bt_8
            // 
            bt_8.Font = new Font("Microsoft Sans Serif", 16F);
            bt_8.Location = new Point(124, 192);
            bt_8.Name = "bt_8";
            bt_8.Size = new Size(97, 67);
            bt_8.TabIndex = 1;
            bt_8.Text = "8";
            bt_8.UseVisualStyleBackColor = true;
            bt_8.Click += bt_8_Click;
            // 
            // bt_7
            // 
            bt_7.Font = new Font("Microsoft Sans Serif", 16F);
            bt_7.Location = new Point(21, 192);
            bt_7.Name = "bt_7";
            bt_7.Size = new Size(97, 64);
            bt_7.TabIndex = 1;
            bt_7.Text = "7";
            bt_7.UseVisualStyleBackColor = true;
            bt_7.Click += bt_7_Click;
            // 
            // bt_9
            // 
            bt_9.Font = new Font("Microsoft Sans Serif", 16F);
            bt_9.Location = new Point(227, 191);
            bt_9.Name = "bt_9";
            bt_9.Size = new Size(97, 67);
            bt_9.TabIndex = 1;
            bt_9.Text = "9";
            bt_9.UseVisualStyleBackColor = true;
            bt_9.Click += bt_9_Click;
            // 
            // bt_soma
            // 
            bt_soma.Font = new Font("Microsoft Sans Serif", 16F);
            bt_soma.Location = new Point(330, 408);
            bt_soma.Name = "bt_soma";
            bt_soma.Size = new Size(99, 67);
            bt_soma.TabIndex = 1;
            bt_soma.Text = "+";
            bt_soma.UseVisualStyleBackColor = true;
            bt_soma.Click += bt_soma_Click_1;
            // 
            // bt_divisao
            // 
            bt_divisao.Font = new Font("Microsoft Sans Serif", 16F);
            bt_divisao.Location = new Point(330, 189);
            bt_divisao.Name = "bt_divisao";
            bt_divisao.Size = new Size(99, 67);
            bt_divisao.TabIndex = 1;
            bt_divisao.Text = "÷";
            bt_divisao.UseVisualStyleBackColor = true;
            bt_divisao.Click += bt_divisao_Click;
            // 
            // bt_subtracao
            // 
            bt_subtracao.Font = new Font("Microsoft Sans Serif", 16F);
            bt_subtracao.Location = new Point(330, 262);
            bt_subtracao.Name = "bt_subtracao";
            bt_subtracao.Size = new Size(99, 67);
            bt_subtracao.TabIndex = 1;
            bt_subtracao.Text = "-";
            bt_subtracao.UseVisualStyleBackColor = true;
            bt_subtracao.Click += bt_subtracao_Click;
            // 
            // bt_multiplicacao
            // 
            bt_multiplicacao.Font = new Font("Microsoft Sans Serif", 16F);
            bt_multiplicacao.Location = new Point(330, 335);
            bt_multiplicacao.Name = "bt_multiplicacao";
            bt_multiplicacao.Size = new Size(99, 67);
            bt_multiplicacao.TabIndex = 1;
            bt_multiplicacao.Text = "x";
            bt_multiplicacao.UseVisualStyleBackColor = true;
            bt_multiplicacao.Click += bt_multiplicacao_Click;
            // 
            // bt_igual
            // 
            bt_igual.Font = new Font("Microsoft Sans Serif", 16F);
            bt_igual.Location = new Point(227, 408);
            bt_igual.Name = "bt_igual";
            bt_igual.Size = new Size(97, 67);
            bt_igual.TabIndex = 1;
            bt_igual.Text = "=";
            bt_igual.UseVisualStyleBackColor = true;
            bt_igual.Click += bt_igual_Click_1;
            // 
            // textbox_resultado
            // 
            textbox_resultado.Location = new Point(21, 97);
            textbox_resultado.Multiline = true;
            textbox_resultado.Name = "textbox_resultado";
            textbox_resultado.Size = new Size(408, 45);
            textbox_resultado.TabIndex = 2;
            // 
            // bt_limpar
            // 
            bt_limpar.Font = new Font("Segoe UI", 16F);
            bt_limpar.Location = new Point(330, 148);
            bt_limpar.Name = "bt_limpar";
            bt_limpar.Size = new Size(99, 35);
            bt_limpar.TabIndex = 3;
            bt_limpar.Text = "C";
            bt_limpar.UseVisualStyleBackColor = true;
            bt_limpar.Click += bt_limpar_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { conversãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(441, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // conversãoToolStripMenuItem
            // 
            conversãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { celsiusParaFahrenheitToolStripMenuItem, fahrenheitParaCelsiusToolStripMenuItem });
            conversãoToolStripMenuItem.Font = new Font("Segoe UI", 13F);
            conversãoToolStripMenuItem.Name = "conversãoToolStripMenuItem";
            conversãoToolStripMenuItem.Size = new Size(108, 29);
            conversãoToolStripMenuItem.Text = "Conversão";
            // 
            // celsiusParaFahrenheitToolStripMenuItem
            // 
            celsiusParaFahrenheitToolStripMenuItem.Name = "celsiusParaFahrenheitToolStripMenuItem";
            celsiusParaFahrenheitToolStripMenuItem.Size = new Size(264, 30);
            celsiusParaFahrenheitToolStripMenuItem.Text = "Celsius para fahrenheit";
            celsiusParaFahrenheitToolStripMenuItem.Click += celsiusParaFahrenheitToolStripMenuItem_Click;
            // 
            // fahrenheitParaCelsiusToolStripMenuItem
            // 
            fahrenheitParaCelsiusToolStripMenuItem.Name = "fahrenheitParaCelsiusToolStripMenuItem";
            fahrenheitParaCelsiusToolStripMenuItem.Size = new Size(264, 30);
            fahrenheitParaCelsiusToolStripMenuItem.Text = "Fahrenheit para Celsius";
            fahrenheitParaCelsiusToolStripMenuItem.Click += fahrenheitParaCelsiusToolStripMenuItem_Click;
            // 
            // tela_calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 487);
            Controls.Add(bt_limpar);
            Controls.Add(textbox_resultado);
            Controls.Add(bt_ponto);
            Controls.Add(bt_subtracao);
            Controls.Add(bt_igual);
            Controls.Add(bt_multiplicacao);
            Controls.Add(bt_divisao);
            Controls.Add(bt_soma);
            Controls.Add(bt_9);
            Controls.Add(bt_6);
            Controls.Add(bt_3);
            Controls.Add(bt_7);
            Controls.Add(bt_4);
            Controls.Add(bt_8);
            Controls.Add(bt_5);
            Controls.Add(bt_2);
            Controls.Add(bt_1);
            Controls.Add(bt_0);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "tela_calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tela_calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_0;
        private Button bt_ponto;
        private Button bt_1;
        private Button bt_2;
        private Button bt_3;
        private Button bt_4;
        private Button bt_6;
        private Button bt_5;
        private Button bt_8;
        private Button bt_7;
        private Button bt_9;
        private Button bt_soma;
        private Button bt_divisao;
        private Button bt_subtracao;
        private Button bt_multiplicacao;
        private Button bt_igual;
        private TextBox textbox_resultado;
        private Button bt_limpar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversãoToolStripMenuItem;
        private ToolStripMenuItem celsiusParaFahrenheitToolStripMenuItem;
        private ToolStripMenuItem fahrenheitParaCelsiusToolStripMenuItem;
    }
}