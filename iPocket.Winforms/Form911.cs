using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form911 = Dashboard / Home screen
    public partial class Form911 : Form
    {
        public Form911()
        {
            InitializeComponent();
            // panel3 = Received Money (transaction detail)
            // panel4 = Send Money
            // panel6 = Home nav (stays on this screen)
            // panel7 = Profile nav
            // pictureBox7 = Settings or other nav
            panel3.Click += panel3_Click;
            panel4.Click += panel4_Click;
            panel6.Click += panel6_Click;
            panel7.Click += panel7_Click;
            pictureBox7.Click += pictureBox7_Click;
            pictureBox1.Click += pictureBox1_Click;
        }

        private void Form911_Load(object sender, EventArgs e) { }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Received Money - show transaction history
            Form916 nextScreen = new Form916();
            nextScreen.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            // Send Money
            Form918 nextScreen = new Form918();
            nextScreen.Show();
            this.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            // Home - already here, do nothing
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            // Profile nav
            Form917 nextScreen = new Form917();
            nextScreen.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Jar of Joy / Savings
            Form912 nextScreen = new Form912();
            nextScreen.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Card picture - go to Jar of Joy
            Form912 nextScreen = new Form912();
            nextScreen.Show();
            this.Hide();
        }
    }
}
