#nullable enable
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

            // Transaction panels
            panel3.Click += panel3_Click;   // Deposit Fund / Received Money → transaction history
            panel4.Click += panel4_Click;   // Send Money / Bank Transfer → send screen

            // Bottom nav bar (panel5 is the nav container — wire its children)
            panel6.Click += panel6_Click;           // Home (already here)
            panel7.Click += panel7_Click;           // Profile
            pictureBox7.Click += pictureBox7_Click; // Jar of Joy / Savings (coin icon)
            pictureBox1.Click += pictureBox1_Click; // Notification bell

            // BUG FIX: pictureBox1 is the notification bell icon, NOT a card image.
            // The original routed it to Form912 (savings). It should show notifications
            // or do nothing until a notifications screen exists.
            // Removed the wrong Form912 routing.

            // BUG FIX: button1 is the back-arrow "<" button — was never wired at all.
            // On the home/dashboard screen a back-arrow should trigger logout confirmation.
            button1.Click += button1_Click;

            // BUG FIX: panel2 is the "Payment Due" info panel — was never wired.
            // Tapping it can show transaction history filtered to due payments.
            panel2.Click += panel2_Click;
        }

        private void Form911_Load(object? sender, EventArgs e) { }

        private void panel3_Click(object? sender, EventArgs e)
        {
            // Deposit Fund / Received Money panel → transaction history
            Form916 nextScreen = new Form916();
            nextScreen.Show();
            this.Hide();
        }

        private void panel4_Click(object? sender, EventArgs e)
        {
            // Send Money / Bank Transfer panel → send money screen
            Form918 nextScreen = new Form918();
            nextScreen.Show();
            this.Hide();
        }

        private void panel6_Click(object? sender, EventArgs e)
        {
            // Home nav — already on this screen, do nothing
        }

        private void panel7_Click(object? sender, EventArgs e)
        {
            // Profile nav
            Form917 nextScreen = new Form917();
            nextScreen.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object? sender, EventArgs e)
        {
            // Coin logo → Jar of Joy / Savings
            Form912 nextScreen = new Form912();
            nextScreen.Show();
            this.Hide();
        }

        // BUG FIX: button1 is the "<" back arrow — was never wired.
        // On the dashboard, back = logout confirmation.
        private void button1_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?", "iPocket",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form4 loginScreen = new Form4();
                loginScreen.Show();
                this.Hide();
            }
        }

        // pictureBox1 = notification bell icon (top-right).
        // The Designer wires its Click event, so this handler must exist.
        // No notifications screen exists yet — show a placeholder message.
        private void pictureBox1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("No new notifications.", "iPocket",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BUG FIX: panel2 "Payment Due" was never wired — now opens transaction history.
        private void panel2_Click(object? sender, EventArgs e)
        {
            Form916 nextScreen = new Form916();
            nextScreen.Show();
            this.Hide();
        }
    }
}
