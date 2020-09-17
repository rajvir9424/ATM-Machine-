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
    public partial class Withdraw : Form
    {
        public static int remaining;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void showbalance_Click(object sender, EventArgs e)
        {
            balancetext.Text = Convert.ToString(MainPage.balance1);
        }

        private void Withdrawamount_Click(object sender, EventArgs e)
        {
            if (int.Parse(amount.Text) > (MainPage.balance1))
            {
                MessageBox.Show("You cannot withdraw" + " " + amount.Text + " " + "as your balance is " + " " + MainPage.balance1);
                
                balancetext.Clear();
                amount.Clear();

            }
            else
            {
                remaining = MainPage.balance1 - int.Parse(amount.Text);

                MessageBox.Show("You have withdrawn" + " " + amount.Text + " " + "And your reamaining balance is" + " " + remaining);

                MainPage.balance1 = remaining;

                balancetext.Clear();
                amount.Clear();

            }
            
            
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            balancetext.Enabled = false;
            balancetext.Text = Convert.ToString(MainPage.balance1);
        }
    }
}
