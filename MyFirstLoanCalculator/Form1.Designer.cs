
namespace MyFirstLoanCalculator
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
            this.labelLoanAmount = new System.Windows.Forms.Label();
            this.labelMonths = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelFinalValue = new System.Windows.Forms.Label();
            this.txtFinalValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLoanAmount
            // 
            this.labelLoanAmount.AutoSize = true;
            this.labelLoanAmount.Location = new System.Drawing.Point(71, 55);
            this.labelLoanAmount.Name = "labelLoanAmount";
            this.labelLoanAmount.Size = new System.Drawing.Size(73, 13);
            this.labelLoanAmount.TabIndex = 0;
            this.labelLoanAmount.Text = "Loan Amount:";
            // 
            // labelMonths
            // 
            this.labelMonths.AutoSize = true;
            this.labelMonths.Location = new System.Drawing.Point(71, 88);
            this.labelMonths.Name = "labelMonths";
            this.labelMonths.Size = new System.Drawing.Size(97, 13);
            this.labelMonths.TabIndex = 1;
            this.labelMonths.Text = "Number of Months:";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Location = new System.Drawing.Point(71, 121);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(71, 13);
            this.labelInterestRate.TabIndex = 2;
            this.labelInterestRate.Text = "Interest Rate:";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(197, 52);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLoanAmount.TabIndex = 3;
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(197, 85);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(100, 20);
            this.txtMonths.TabIndex = 4;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(197, 118);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 5;
            this.txtInterestRate.Text = "0.005";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 173);
            this.listBox1.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(69, 392);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 37);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 392);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 37);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(327, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelFinalValue
            // 
            this.labelFinalValue.AutoSize = true;
            this.labelFinalValue.Location = new System.Drawing.Point(69, 359);
            this.labelFinalValue.Name = "labelFinalValue";
            this.labelFinalValue.Size = new System.Drawing.Size(62, 13);
            this.labelFinalValue.TabIndex = 10;
            this.labelFinalValue.Text = "Final Value:";
            // 
            // txtFinalValue
            // 
            this.txtFinalValue.Location = new System.Drawing.Point(150, 356);
            this.txtFinalValue.Name = "txtFinalValue";
            this.txtFinalValue.ReadOnly = true;
            this.txtFinalValue.Size = new System.Drawing.Size(268, 20);
            this.txtFinalValue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.txtFinalValue);
            this.Controls.Add(this.labelFinalValue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelMonths);
            this.Controls.Add(this.labelLoanAmount);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoanAmount;
        private System.Windows.Forms.Label labelMonths;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelFinalValue;
        private System.Windows.Forms.TextBox txtFinalValue;
    }
}

