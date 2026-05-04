using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            backarrow.Click += backarrow_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Continue to PIN setup
            Form8 nextScreen = new Form8();
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form6 prevScreen = new Form6();
            prevScreen.Show();
            this.Hide();
        }
    }
}
