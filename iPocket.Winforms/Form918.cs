using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form918 = Transaction History
    public partial class Form918 : Form
    {
        public Form918()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            label2.Click += label2_Click;
            label3.Click += label3_Click;
            label4.Click += label4_Click;
        }

        private void Form918_Load(object sender, EventArgs e) { }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form911 prevScreen = new Form911();
            prevScreen.Show();
            this.Hide();
        }

        private void label27_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { /* All filter */ }
        private void label3_Click(object sender, EventArgs e) { /* Deposit filter */ }
        private void label4_Click(object sender, EventArgs e) { /* Transfer filter */ }
    }
}
