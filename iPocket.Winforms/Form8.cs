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

        public Form8()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            button1.Click += button1_Click;
            button2.Click += (s, e) => TypeDigit("1");
            button3.Click += (s, e) => TypeDigit("2");
            button4.Click += (s, e) => TypeDigit("3");
            button7.Click += (s, e) => TypeDigit("4");
            button6.Click += (s, e) => TypeDigit("5");
            button5.Click += (s, e) => TypeDigit("6");
            button10.Click += (s, e) => TypeDigit("7");
            button9.Click += (s, e) => TypeDigit("8");
            button8.Click += (s, e) => TypeDigit("9");
            button12.Click += (s, e) => TypeDigit("0");
            button11.Click += (s, e) => Backspace();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 6 || textBox2.Text.Length < 6)
            {
                MessageBox.Show("Please enter and confirm your 6-digit PIN.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("PINs do not match. Please try again.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                enteringConfirmPin = false;
                return;
            }
            // Go to KYC / Verify Identity
            Form9 nextScreen = new Form9();
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form7 prevScreen = new Form7();
            prevScreen.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
