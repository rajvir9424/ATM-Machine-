using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Deposit : Form
    {
        int depositamount;
        public Deposit()
        {
            InitializeComponent();
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {

            depositamount = int.Parse(deposittext.Text) + MainPage.balance1;

            MessageBox.Show("You have deposited" + " " + deposittext.Text + " " + "And your new balance is " + " " + depositamount);

            deposittext.Clear();

            MainPage.balance1 = depositamount;
        }
    }
}
