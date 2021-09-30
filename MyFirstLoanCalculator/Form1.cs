using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstLoanCalculator
{
    public partial class Form1 : Form
    {

        decimal loanAmount = 0.00m;
        int numberOfMonths = 0;
        decimal interestRate = 0.005m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // assign new values to the variables

            // Done with a try catch
            //try {
            //    loanAmount = decimal.Parse(txtLoanAmount.Text);
            //    numberOfMonths = int.Parse(txtMonths.Text);
            //    interestRate = decimal.Parse(txtInterestRate.Text);
            //}
            //catch { 
            //     MessageBox.Show("Please enter a number here ");
            //}

            // Done With nested if statements and while loop
            if (decimal.TryParse(txtLoanAmount.Text, out loanAmount))
            {
                if ( int.TryParse(txtMonths.Text, out numberOfMonths))
                {
                    if (decimal.TryParse(txtInterestRate.Text, out interestRate))
                    {
                        // success

                        //calculate the loan
                        int counter = 0;
                        while(counter < numberOfMonths)
                        {
                            loanAmount = loanAmount + loanAmount * interestRate;
                            listBox1.Items.Add("At month " + counter + " the loan is: " + loanAmount.ToString("c"));
                            counter = counter + 1;
                        }
                        //done with the while loop
                        txtFinalValue.Text = loanAmount.ToString("c");
                    }
                }
            }
            
            

            //MessageBox.Show("You entered " + loanAmount + " months = " + numberOfMonths + " rate = " + interestRate);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text from text boxes and from the list box
            txtFinalValue.Text = "";
            txtInterestRate.Text = "";
            txtLoanAmount.Text = "";
            txtMonths.Text = "";
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close applicaltion
            this.Close();
        }
    }
}
