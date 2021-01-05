
namespace Calculatin_Fuel_Economy
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
            this.lblMilesDriven = new System.Windows.Forms.Label();
            this.lblgallonsOfGas = new System.Windows.Forms.Label();
            this.lblMPG = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGasGallons = new System.Windows.Forms.TextBox();
            this.txtMPG = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMilesDriven
            // 
            this.lblMilesDriven.AutoSize = true;
            this.lblMilesDriven.Location = new System.Drawing.Point(55, 36);
            this.lblMilesDriven.Name = "lblMilesDriven";
            this.lblMilesDriven.Size = new System.Drawing.Size(161, 13);
            this.lblMilesDriven.TabIndex = 0;
            this.lblMilesDriven.Text = "Enter the number of miles driven:";
            // 
            // lblgallonsOfGas
            // 
            this.lblgallonsOfGas.AutoSize = true;
            this.lblgallonsOfGas.Location = new System.Drawing.Point(58, 70);
            this.lblgallonsOfGas.Name = "lblgallonsOfGas";
            this.lblgallonsOfGas.Size = new System.Drawing.Size(144, 13);
            this.lblgallonsOfGas.TabIndex = 1;
            this.lblgallonsOfGas.Text = "Enter the gallons of gas used";
            // 
            // lblMPG
            // 
            this.lblMPG.AutoSize = true;
            this.lblMPG.Location = new System.Drawing.Point(132, 127);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(84, 13);
            this.lblMPG.TabIndex = 2;
            this.lblMPG.Text = "Your car\'s MPG:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(285, 36);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 3;
            // 
            // txtGasGallons
            // 
            this.txtGasGallons.Location = new System.Drawing.Point(285, 70);
            this.txtGasGallons.Name = "txtGasGallons";
            this.txtGasGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGasGallons.TabIndex = 4;
            // 
            // txtMPG
            // 
            this.txtMPG.Location = new System.Drawing.Point(252, 120);
            this.txtMPG.Name = "txtMPG";
            this.txtMPG.Size = new System.Drawing.Size(100, 20);
            this.txtMPG.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(64, 182);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "CalculateMPG";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 182);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMPG);
            this.Controls.Add(this.txtGasGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.lblgallonsOfGas);
            this.Controls.Add(this.lblMilesDriven);
            this.Name = "Form1";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMilesDriven;
        private System.Windows.Forms.Label lblgallonsOfGas;
        private System.Windows.Forms.Label lblMPG;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGasGallons;
        private System.Windows.Forms.TextBox txtMPG;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

