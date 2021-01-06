
namespace Change_Counter_Application
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picFivftyCents = new System.Windows.Forms.PictureBox();
            this.picTwentyFiveCents = new System.Windows.Forms.PictureBox();
            this.picTenCents = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFivftyCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwentyFiveCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenCents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(164, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(406, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Click the Coin";
            // 
            // picFivftyCents
            // 
            this.picFivftyCents.Image = global::Change_Counter_Application.Properties.Resources._50cents;
            this.picFivftyCents.Location = new System.Drawing.Point(228, 176);
            this.picFivftyCents.Name = "picFivftyCents";
            this.picFivftyCents.Size = new System.Drawing.Size(100, 50);
            this.picFivftyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFivftyCents.TabIndex = 3;
            this.picFivftyCents.TabStop = false;
            this.picFivftyCents.Click += new System.EventHandler(this.picFivftyCents_Click);
            // 
            // picTwentyFiveCents
            // 
            this.picTwentyFiveCents.Image = global::Change_Counter_Application.Properties.Resources._25cents;
            this.picTwentyFiveCents.Location = new System.Drawing.Point(61, 176);
            this.picTwentyFiveCents.Name = "picTwentyFiveCents";
            this.picTwentyFiveCents.Size = new System.Drawing.Size(100, 50);
            this.picTwentyFiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwentyFiveCents.TabIndex = 2;
            this.picTwentyFiveCents.TabStop = false;
            this.picTwentyFiveCents.Click += new System.EventHandler(this.picTwentyFiveCents_Click);
            // 
            // picTenCents
            // 
            this.picTenCents.Image = global::Change_Counter_Application.Properties.Resources._10cents;
            this.picTenCents.Location = new System.Drawing.Point(228, 56);
            this.picTenCents.Name = "picTenCents";
            this.picTenCents.Size = new System.Drawing.Size(100, 50);
            this.picTenCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenCents.TabIndex = 1;
            this.picTenCents.TabStop = false;
            this.picTenCents.Click += new System.EventHandler(this.picTenCents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Change_Counter_Application.Properties.Resources._5cents;
            this.pictureBox1.Location = new System.Drawing.Point(51, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 316);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picFivftyCents);
            this.Controls.Add(this.picTwentyFiveCents);
            this.Controls.Add(this.picTenCents);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFivftyCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwentyFiveCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenCents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picTenCents;
        private System.Windows.Forms.PictureBox picTwentyFiveCents;
        private System.Windows.Forms.PictureBox picFivftyCents;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}

