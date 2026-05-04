using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form917 = Profile screen
    public partial class Form917 : Form
    {
        public Form917()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            pictureBox3.Click += pictureBox3_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logout
            var result = MessageBox.Show("Are you sure you want to logout?", "iPocket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form4 loginScreen = new Form4();
                loginScreen.Show();
                this.Hide();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Settings
            Form919 nextScreen = new Form919();
            nextScreen.Show();
            this.Hide();
        }
    }
}
