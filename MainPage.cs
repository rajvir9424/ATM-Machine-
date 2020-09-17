using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    
    public partial class MainPage : Form
    {
      public static int balance1 = 15000 ;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnbalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your balance is " +   balance1);


           
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            ChangePin cg = new ChangePin();
            cg.Show();
        }

        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           

           

            Form1 f1 = new Form1();
            this.Hide();
            f1.Show(); 


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static void close()
        {
            MainPage mg = new MainPage();
            mg.Close();
        }
    }
}
