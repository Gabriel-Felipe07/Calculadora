namespace Calculadora
{
    partial class frm_converteCentimetrosParaPolegadas
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            button_converter = new Button();
            textBox_valor_convertido = new TextBox();
            textBox_centimetros = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, voltarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(180, 22);
            voltarToolStripMenuItem.Text = "Voltar";
            // 
            // button_converter
            // 
            button_converter.Font = new Font("Segoe UI", 16F);
            button_converter.Location = new Point(352, 260);
            button_converter.Name = "button_converter";
            button_converter.Size = new Size(126, 45);
            button_converter.TabIndex = 1;
            button_converter.Text = "Converter";
            button_converter.UseVisualStyleBackColor = true;
            // 
            // textBox_valor_convertido
            // 
            textBox_valor_convertido.Font = new Font("Segoe UI", 16F);
            textBox_valor_convertido.Location = new Point(441, 113);
            textBox_valor_convertido.Multiline = true;
            textBox_valor_convertido.Name = "textBox_valor_convertido";
            textBox_valor_convertido.PlaceholderText = "Valor Convertido";
            textBox_valor_convertido.Size = new Size(236, 96);
            textBox_valor_convertido.TabIndex = 2;
            // 
            // textBox_centimetros
            // 
            textBox_centimetros.Font = new Font("Microsoft Sans Serif", 16F);
            textBox_centimetros.Location = new Point(154, 117);
            textBox_centimetros.Multiline = true;
            textBox_centimetros.Name = "textBox_centimetros";
            textBox_centimetros.PlaceholderText = "Valor em Centímetros";
            textBox_centimetros.Size = new Size(236, 96);
            textBox_centimetros.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(154, 38);
            label1.Name = "label1";
            label1.Size = new Size(523, 30);
            label1.TabIndex = 3;
            label1.Text = "Conversor de medidas (Centímetros para Polegadas)";
            // 
            // frm_converteCentimetrosParaPolegadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox_centimetros);
            Controls.Add(textBox_valor_convertido);
            Controls.Add(button_converter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_converteCentimetrosParaPolegadas";
            Text = "frm_converteCentimetrosParaPolegadas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Button button_converter;
        private TextBox textBox_valor_convertido;
        private TextBox textBox_centimetros;
        private Label label1;
    }
}