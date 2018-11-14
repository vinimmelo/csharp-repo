using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        private double milesTraveled, reimburseRate = 0.39, amountOwned;

        private void button1_Click(object sender, EventArgs e)
        {
            if(startingMileage.Value > endingMileage.Value)
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.");
                return;
            }

            milesTraveled = (double) (endingMileage.Value - startingMileage.Value);
            amountOwned = milesTraveled *= reimburseRate;
            label4.Text = "$" + amountOwned;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
