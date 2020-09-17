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
    public partial class ChangePin : Form
    {
        string changedpin;
        public ChangePin()
        {
            InitializeComponent();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {
            newpin.Enabled = false;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {


            Form1.pin1 = newpin.Text;

            MessageBox.Show("Your pin has been changed and your new pin is" +  " "+   newpin.Text);

            newpin.Clear();

        }

        private void pintext_TextChanged(object sender, EventArgs e)
        {
            newpin.PasswordChar = '*';
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            newpin.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oldpin.Clear();
        }

        private void oldenter_Click(object sender, EventArgs e)
        {
            if (oldpin.Text == Form1.pin1)
            {
                newpin.Enabled = true;

                MessageBox.Show("Correct pin , Please set a new pin below");

                oldpin.Clear();


            }
            else
            {
                MessageBox.Show("Wrong pin entered please enter correct to set a new one");

                oldpin.Clear();
            }
        }

        private void oldpin_TextChanged(object sender, EventArgs e)
        {
            oldpin.PasswordChar = '*';
        }
    }
}
