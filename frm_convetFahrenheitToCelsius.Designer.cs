﻿namespace Calculadora
{
    partial class frm_convetFahrenheitToCelsius
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
            button_converter = new Button();
            textBox_fahrenheit = new TextBox();
            textBox_valor_convertido = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button_converter
            // 
            button_converter.Font = new Font("Segoe UI", 16F);
            button_converter.Location = new Point(325, 319);
            button_converter.Name = "button_converter";
            button_converter.Size = new Size(135, 69);
            button_converter.TabIndex = 0;
            button_converter.Text = "Converter";
            button_converter.UseVisualStyleBackColor = true;
            button_converter.Click += button_converter_Click;
            // 
            // textBox_fahrenheit
            // 
            textBox_fahrenheit.Font = new Font("Segoe UI", 16F);
            textBox_fahrenheit.Location = new Point(111, 148);
            textBox_fahrenheit.Multiline = true;
            textBox_fahrenheit.Name = "textBox_fahrenheit";
            textBox_fahrenheit.PlaceholderText = "Valor em Fahrenheit";
            textBox_fahrenheit.Size = new Size(214, 80);
            textBox_fahrenheit.TabIndex = 1;
            // 
            // textBox_valor_convertido
            // 
            textBox_valor_convertido.Font = new Font("Segoe UI", 16F);
            textBox_valor_convertido.Location = new Point(543, 148);
            textBox_valor_convertido.Multiline = true;
            textBox_valor_convertido.Name = "textBox_valor_convertido";
            textBox_valor_convertido.PlaceholderText = "Valor Convertido";
            textBox_valor_convertido.Size = new Size(214, 80);
            textBox_valor_convertido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(160, 33);
            label1.Name = "label1";
            label1.Size = new Size(517, 30);
            label1.TabIndex = 2;
            label1.Text = "Conversor de temperatuda (Fahrenheit para Celsius)";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
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
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(180, 22);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // frm_convetFahrenheitToCelsius
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox_valor_convertido);
            Controls.Add(textBox_fahrenheit);
            Controls.Add(button_converter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_convetFahrenheitToCelsius";
            Text = "frm_convetFahrenheitToCelsius";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_converter;
        private TextBox textBox_fahrenheit;
        private TextBox textBox_valor_convertido;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}