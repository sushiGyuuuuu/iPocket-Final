using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form8 : Form
    {
        private bool enteringConfirmPin = false;

        // BUG FIX: receive user details from Form7 and carry them forward
        private readonly string _fullName;
        private readonly string _password;
        private readonly string _email;

        public Form8(string fullName = "", string password = "", string email = "")
        {
            InitializeComponent();
            _fullName = fullName;
            _password = password;
            _email    = email;

            backarrow.Click += backarrow_Click;
            button1.Click   += button1_Click;
            button2.Click   += (s, e) => TypeDigit("1");
            button3.Click   += (s, e) => TypeDigit("2");
            button4.Click   += (s, e) => TypeDigit("3");
            button7.Click   += (s, e) => TypeDigit("4");
            button6.Click   += (s, e) => TypeDigit("5");
            button5.Click   += (s, e) => TypeDigit("6");
            button10.Click  += (s, e) => TypeDigit("7");
            button9.Click   += (s, e) => TypeDigit("8");
            button8.Click   += (s, e) => TypeDigit("9");
            button12.Click  += (s, e) => TypeDigit("0");
            button11.Click  += (s, e) => Backspace();
        }

        private void TypeDigit(string digit)
        {
            var target = enteringConfirmPin ? textBox2 : textBox1;
            if (target.Text.Length < 6)
            {
                target.Text += digit;
                // Auto-move to confirm PIN after 6 digits
                if (!enteringConfirmPin && textBox1.Text.Length == 6)
                    enteringConfirmPin = true;
            }
        }

        private void Backspace()
        {
            var target = enteringConfirmPin ? textBox2 : textBox1;
            if (target.Text.Length > 0)
                target.Text = target.Text.Substring(0, target.Text.Length - 1);
            else if (enteringConfirmPin)
                enteringConfirmPin = false;
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text.Length < 6 || textBox2.Text.Length < 6)
            {
                MessageBox.Show("Please enter and confirm your 6-digit PIN.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("PINs do not match. Please try again.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                enteringConfirmPin = false;
                return;
            }

            // BUG FIX: pass all collected registration data (name, password, email, PIN) to KYC screen
            Form9 nextScreen = new Form9(_fullName, _password, _email, textBox1.Text);
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            // BUG FIX: original created new Form7() with no arguments, losing the
            // user's already-typed name, password and email. Pass them back.
            Form7 prevScreen = new Form7(_fullName, _password, _email);
            prevScreen.Show();
            this.Hide();
        }

        private void label1_Click(object? sender, EventArgs e) { }
    }
}
