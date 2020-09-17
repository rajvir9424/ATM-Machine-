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
    public partial class Form1 : Form
    {
       public static string pin1 = "4040";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pintext_TextChanged(object sender, EventArgs e)
        {
            pintext.PasswordChar = '*';

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if (pin1==pintext.Text)
            {
                MainPage pge = new MainPage();

                MessageBox.Show("Correct Pin Entered Welcome");
           
                pge.Show();
                pintext.Clear();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect pin, try again");
                pintext.Clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            pintext.Clear();
        }
    }
}
