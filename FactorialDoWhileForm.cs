/*
 * Created by: Jadon Fournier
 * Created on: 21-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program allows you to find the factorials of a user inputted number.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialDoWhile
{
    public partial class frmFactorialDoWhile : Form
    {
        //Define variables
        double FactNumber;
        double FactAnswer = 1;
        string FactNumberTxt;
        string FactAnswerTxt;
        int FactCounter = 0;

        public frmFactorialDoWhile()
        {
            InitializeComponent();

            //Hide labels
            this.lblAnswer.Hide();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            FactNumber = Convert.ToDouble(txtInput.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Clear the listbox
            this.lstListBox.Items.Clear();

            do
            {
                //Increment the counter
                FactCounter = FactCounter + 1;

                //Add the counter to the list
                this.lstListBox.Items.Add(FactCounter);

                //Multiply the factorial by the counter
                FactAnswer = FactAnswer * FactCounter;

            } while (FactNumber != FactCounter);

            //Convert the numbers needed to strings and set the label, then show the label
            FactNumberTxt = Convert.ToString(FactNumber);
            FactAnswerTxt = Convert.ToString(FactAnswer);
            lblAnswer.Text = "The factorial of " + FactNumberTxt + " is " + FactAnswerTxt + ".";
            this.lblAnswer.Show();
        }
    }
}
