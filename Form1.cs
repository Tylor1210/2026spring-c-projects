using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int numberOfCars;
            if(LstCarType.SelectedIndex == -1)
            {
                MessageBox.Show("No car type has been selected.");
            }
            else if(!int.TryParse(tbNumCars.Text, out numberOfCars))
            {
                MessageBox.Show("Invalid number of cars.");
            }
            else
            {
                lblQuote.Text = LstCarType.SelectedItem.ToString();
                lblQuote.Text += " x " + numberOfCars.ToString();
                

            }
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            lblQuote.Text = "";
            tbNumCars.Text = "0";
        }
    }
}
