
namespace Temperature_Converter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtConvertedTemperature = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the temperature here:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(195, 27);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtTemperature.TabIndex = 1;
            // 
            // txtConvertedTemperature
            // 
            this.txtConvertedTemperature.Location = new System.Drawing.Point(145, 92);
            this.txtConvertedTemperature.Name = "txtConvertedTemperature";
            this.txtConvertedTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtConvertedTemperature.TabIndex = 2;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(56, 153);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(121, 23);
            this.btnFahrenheit.TabIndex = 3;
            this.btnFahrenheit.Text = "Convert to Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.Location = new System.Drawing.Point(207, 153);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(107, 23);
            this.btnCelsius.TabIndex = 4;
            this.btnCelsius.Text = "Convert to Celsius";
            this.btnCelsius.UseVisualStyleBackColor = true;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 302);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.txtConvertedTemperature);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtConvertedTemperature;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCelsius;
    }
}

