/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 2
* Due Date:  Jan.27, 2015
*
* Program Purpose:  Create an application that allows the user
* to enter the number of tickets sold for 3 classes of ticket. 
* The application should be able to display the amount of income 
* generated from each class of ticket sales and the total 
* revenue generated.
*
****/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        const decimal CLASS_A_VALUE = 15.00m;
        const decimal CLASS_B_VALUE = 12.00m;
        const decimal CLASS_C_VALUE = 9.00m;

        private decimal classATotal = 0m;
        private decimal classBTotal = 0m;
        private decimal classCTotal = 0m;
        private decimal total = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcRevenueButton_Click(object sender, EventArgs e)
        {
            int classANumber = int.Parse(classATextBox.Text);
            int classBNumber = int.Parse(classBTextBox.Text);
            int classCNumber = int.Parse(classCTextBox.Text);

            classATotal = classANumber * CLASS_A_VALUE;

            calculatedClassALabel.Text = classATotal.ToString("c");

            classBTotal = classBNumber * CLASS_B_VALUE;

            calculatedClassBLabel.Text = classBTotal.ToString("c");

            classCTotal = classCNumber * CLASS_C_VALUE;

            calculatedClassCLabel.Text = classCTotal.ToString("c");

            total = classATotal + classBTotal + classCTotal;

            calculatedTotalLabel.Text = total.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            classATotal = 0m;
            classBTotal = 0m;
            classCTotal = 0m;
            total = 0m;

            classATextBox.Text = "";
            classBTextBox.Text = "";
            classCTextBox.Text = "";

            calculatedClassALabel.Text = "";
            calculatedClassBLabel.Text = "";
            calculatedClassCLabel.Text = "";
            calculatedTotalLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
