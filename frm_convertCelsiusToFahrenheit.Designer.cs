namespace Calculadora
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
            label1.Size = new Size(508, 30);
            label1.TabIndex = 2;
            label1.Text = "Conversor de temperaturas (celcius para fahrenheit";
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
            Name = "frm_convertCelsiusToFahrenheit";
            Text = "convertCelsiusToFahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_converter;
        private TextBox textBox_celsius;
        private TextBox textBox_fahrenheit;
        private Label label1;
    }
}