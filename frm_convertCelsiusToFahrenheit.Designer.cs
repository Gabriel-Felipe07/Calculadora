﻿namespace Calculadora
{
    partial class frm_convertCelsiusToFahrenheit
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
            textBox_celsius = new TextBox();
            textBox_fahrenheit = new TextBox();
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
            button_converter.Location = new Point(317, 214);
            button_converter.Name = "button_converter";
            button_converter.Size = new Size(192, 55);
            button_converter.TabIndex = 0;
            button_converter.Text = "Converter";
            button_converter.UseVisualStyleBackColor = true;
            button_converter.Click += button_converter_Click;
            // 
            // textBox_celsius
            // 
            textBox_celsius.Font = new Font("Segoe UI", 16F);
            textBox_celsius.Location = new Point(162, 68);
            textBox_celsius.Multiline = true;
            textBox_celsius.Name = "textBox_celsius";
            textBox_celsius.PlaceholderText = "Valor em Celsius";
            textBox_celsius.Size = new Size(195, 76);
            textBox_celsius.TabIndex = 1;
            // 
            // textBox_fahrenheit
            // 
            textBox_fahrenheit.Font = new Font("Segoe UI", 16F);
            textBox_fahrenheit.Location = new Point(475, 68);
            textBox_fahrenheit.Multiline = true;
            textBox_fahrenheit.Name = "textBox_fahrenheit";
            textBox_fahrenheit.PlaceholderText = "Valor Convertido";
            textBox_fahrenheit.Size = new Size(195, 76);
            textBox_fahrenheit.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(515, 30);
            label1.TabIndex = 2;
            label1.Text = "Conversor de temperaturas (celcius para fahrenheit)";
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
            // frm_convertCelsiusToFahrenheit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox_fahrenheit);
            Controls.Add(textBox_celsius);
            Controls.Add(button_converter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_convertCelsiusToFahrenheit";
            Text = "convertCelsiusToFahrenheit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_converter;
        private TextBox textBox_celsius;
        private TextBox textBox_fahrenheit;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
    }
}