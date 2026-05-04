using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form912 = Jar of Joy (Savings) screen
    public partial class Form912 : Form
    {
        public Form912()
        {
            InitializeComponent();
            panel3.Click += panel3_Click;
            panel4.Click += panel4_Click;
            panel6.Click += panel6_Click;
            panel7.Click += panel7_Click;
            pictureBox7.Click += pictureBox7_Click;
            pictureBox8.Click += pictureBox8_Click;
            button1.Click += button1_Click;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Deposit Fund
            Form913 nextScreen = new Form913();
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
            // Home nav
            Form911 nextScreen = new Form911();
            nextScreen.Show();
            this.Hide();
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
            // Jar of Joy - already here
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Growth Details
            Form915 nextScreen = new Form915();
            nextScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Deposit
            Form913 nextScreen = new Form913();
            nextScreen.Show();
            this.Hide();
        }
    }
}
