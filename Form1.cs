using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbCard1_Click(object sender, EventArgs e)
        {
            lbCardName.Text = "King of Spades";
        }

        private void pbCard2_Click(object sender, EventArgs e)
        {
            lbCardName.Text = "Ace of Spades";
        }

        private void pbCard3_Click(object sender, EventArgs e)
        {
            lbCardName.Text = "2 of Clubs";
        }

        private void pbCard4_Click(object sender, EventArgs e)
        {
            lbCardName.Text = "8 of Diamonds";
        }

        private void pbCard5_Click(object sender, EventArgs e)
        {
            lbCardName.Text = "Black Joker";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
