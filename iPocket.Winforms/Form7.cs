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
        public Form7(string fullName = "", string password = "", string email = "")
        {
            InitializeComponent();
            button1.Click += button1_Click;
            backarrow.Click += backarrow_Click;

            // BUG FIX: restore values when navigating back from Form8
            textBox1.Text = fullName;
            textBox2.Text = password;
            textBox3.Text = email;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // BUG FIX: validate email field (textBox3) has a proper format if provided
            if (!string.IsNullOrWhiteSpace(textBox3.Text) &&
                !textBox3.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // BUG FIX: pass user details forward to Form8 so they survive to registration
            Form8 nextScreen = new Form8(textBox1.Text, textBox2.Text, textBox3.Text);
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            // BUG FIX: original created a blank Form6() losing the phone number.
            // Registration flow doesn't re-need the phone — go back to Form6 in
            // registration mode (phone number already verified at this point, so
            // just show a fresh OTP screen is wrong; best UX is to go back to Form4).
            Form4 prevScreen = new Form4(isLogin: false);
            prevScreen.Show();
            this.Hide();
        }
    }
}
