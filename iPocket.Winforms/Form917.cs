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
            button1.Click += button1_Click;       // Logout button

            // pictureBox1 = settings icon (top-right gear) → Settings screen
            // BUG FIX: pictureBox1 was never wired in the original code
            pictureBox1.Click += pictureBox1_Click;

            // pictureBox3 = pencil/edit icon next to the user name → Settings
            pictureBox3.Click += pictureBox3_Click;

            // BUG FIX (self-correction): panel4 in Form917 is the "Member Since" info
            // panel — NOT a home nav. Wiring it as home nav was wrong and would have
            // navigated away when the user just tapped their join date. Removed.
            // The correct back/home path is pictureBox1 (settings) or the logout button.
            // There is no dedicated back-arrow on the Profile screen by design.
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Logout
            var result = MessageBox.Show("Are you sure you want to logout?", "iPocket",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form4 loginScreen = new Form4();
                loginScreen.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object? sender, EventArgs e)
        {
            // Settings icon (top-right)
            Form919 nextScreen = new Form919();
            nextScreen.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object? sender, EventArgs e)
        {
            // Pencil/edit icon → Settings
            Form919 nextScreen = new Form919();
            nextScreen.Show();
            this.Hide();
        }
    }
}
