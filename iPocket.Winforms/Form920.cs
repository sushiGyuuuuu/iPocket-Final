using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form920 = Enter Email Address screen (for account recovery / alternate sign-up)
    // BUG FIX: Form920 had an empty constructor with no event wiring whatsoever —
    // the Continue button did nothing and there was no back navigation.
    public partial class Form920 : Form
    {
        public Form920()
        {
            InitializeComponent();
            // BUG FIX: backarrow exists in the designer but was never wired
            backarrow.Click += backarrow_Click;
            button1.Click += button1_Click;
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            // Back to sign-up / login choice screen
            Form4 prevScreen = new Form4();
            prevScreen.Show();
            this.Hide();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !textBox1.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email entered → send OTP to email, go to OTP screen (login flow)
            Form6 nextScreen = new Form6(textBox1.Text, isLogin: true);
            nextScreen.Show();
            this.Hide();
        }
    }
}
