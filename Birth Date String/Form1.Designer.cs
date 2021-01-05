
namespace Birth_Date_String
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
            this.lbldayOfWeekPrompt = new System.Windows.Forms.Label();
            this.lblmonthPrompt = new System.Windows.Forms.Label();
            this.lbldayOfMonth = new System.Windows.Forms.Label();
            this.lblYearPrompt = new System.Windows.Forms.Label();
            this.txtDayOfWeek = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDayOfMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayOfWeekPrompt
            // 
            this.lbldayOfWeekPrompt.AutoSize = true;
            this.lbldayOfWeekPrompt.Location = new System.Drawing.Point(13, 29);
            this.lbldayOfWeekPrompt.Name = "lbldayOfWeekPrompt";
            this.lbldayOfWeekPrompt.Size = new System.Drawing.Size(132, 13);
            this.lbldayOfWeekPrompt.TabIndex = 0;
            this.lbldayOfWeekPrompt.Text = "Enter the day of the week:";
            // 
            // lblmonthPrompt
            // 
            this.lblmonthPrompt.AutoSize = true;
            this.lblmonthPrompt.Location = new System.Drawing.Point(16, 69);
            this.lblmonthPrompt.Name = "lblmonthPrompt";
            this.lblmonthPrompt.Size = new System.Drawing.Size(144, 13);
            this.lblmonthPrompt.TabIndex = 1;
            this.lblmonthPrompt.Text = "Enter the name of the month:";
            // 
            // lbldayOfMonth
            // 
            this.lbldayOfMonth.AutoSize = true;
            this.lbldayOfMonth.Location = new System.Drawing.Point(19, 105);
            this.lbldayOfMonth.Name = "lbldayOfMonth";
            this.lbldayOfMonth.Size = new System.Drawing.Size(175, 13);
            this.lbldayOfMonth.TabIndex = 2;
            this.lbldayOfMonth.Text = "Enter the numeric day of the month:";
            // 
            // lblYearPrompt
            // 
            this.lblYearPrompt.AutoSize = true;
            this.lblYearPrompt.Location = new System.Drawing.Point(19, 141);
            this.lblYearPrompt.Name = "lblYearPrompt";
            this.lblYearPrompt.Size = new System.Drawing.Size(76, 13);
            this.lblYearPrompt.TabIndex = 3;
            this.lblYearPrompt.Text = "Enter the year:";
            // 
            // txtDayOfWeek
            // 
            this.txtDayOfWeek.Location = new System.Drawing.Point(260, 21);
            this.txtDayOfWeek.Name = "txtDayOfWeek";
            this.txtDayOfWeek.Size = new System.Drawing.Size(153, 20);
            this.txtDayOfWeek.TabIndex = 4;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(260, 61);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(153, 20);
            this.txtMonth.TabIndex = 5;
            // 
            // txtDayOfMonth
            // 
            this.txtDayOfMonth.Location = new System.Drawing.Point(260, 105);
            this.txtDayOfMonth.Name = "txtDayOfMonth";
            this.txtDayOfMonth.Size = new System.Drawing.Size(153, 20);
            this.txtDayOfMonth.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(260, 141);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(153, 20);
            this.txtYear.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(22, 207);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(391, 20);
            this.txtOutput.TabIndex = 8;
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(22, 283);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(75, 23);
            this.btnShowDate.TabIndex = 9;
            this.btnShowDate.Text = "Show Date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 356);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowDate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDayOfMonth);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDayOfWeek);
            this.Controls.Add(this.lblYearPrompt);
            this.Controls.Add(this.lbldayOfMonth);
            this.Controls.Add(this.lblmonthPrompt);
            this.Controls.Add(this.lbldayOfWeekPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayOfWeekPrompt;
        private System.Windows.Forms.Label lblmonthPrompt;
        private System.Windows.Forms.Label lbldayOfMonth;
        private System.Windows.Forms.Label lblYearPrompt;
        private System.Windows.Forms.TextBox txtDayOfWeek;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDayOfMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

