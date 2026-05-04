using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form919 = Settings screen
    public partial class Form919 : Form
    {
        public Form919()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            pictureBox2.Click += pictureBox2_Click;
            panel2.Click += panel2_Click;
            panel3.Click += panel3_Click;
            panel5.Click += panel5_Click;
            panel6.Click += panel6_Click;
            panel7.Click += panel7_Click;
        }

        private void Form919_Load(object sender, EventArgs e) { }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form917 prevScreen = new Form917();
            prevScreen.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Back to profile
            Form917 prevScreen = new Form917();
            prevScreen.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            // Edit Profile
            MessageBox.Show("Edit Profile feature coming soon.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            // Change Password
            MessageBox.Show("Change Password feature coming soon.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            // Security
            MessageBox.Show("Security settings coming soon.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            // Help and Support
            MessageBox.Show("Help & Support: contact@ipocket.ph", "iPocket Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            // About iPocket
            MessageBox.Show("iPocket v1.0.0\nYour trusted digital savings wallet.", "About iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
