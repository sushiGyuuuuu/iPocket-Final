using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form5 : Form
    {
        // BUG FIX: carry the login flag through so Form6 knows which flow it's in
        private readonly bool _isLogin;

        public Form5(bool isLogin = false)
        {
            InitializeComponent();
            _isLogin = isLogin;

            // Wire numpad buttons
            button2.Click  += (s, e) => TypeDigit("1");
            button3.Click  += (s, e) => TypeDigit("2");
            button4.Click  += (s, e) => TypeDigit("3");
            button7.Click  += (s, e) => TypeDigit("4");
            button6.Click  += (s, e) => TypeDigit("5");
            button5.Click  += (s, e) => TypeDigit("6");
            button10.Click += (s, e) => TypeDigit("7");
            button9.Click  += (s, e) => TypeDigit("8");
            button8.Click  += (s, e) => TypeDigit("9");
            button12.Click += (s, e) => TypeDigit("0");
            button11.Click += (s, e) => Backspace();
            button1.Click  += (s, e) => button1_Click(s!, e);   // Continue
            backarrow.Click += (s, e) => backarrow_Click(s!, e);
        }

        private void TypeDigit(string digit)
        {
            if (textBox1.Text.Length < 11)
                textBox1.Text += digit;
        }

        private void Backspace()
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Form5_Load(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeDigit("3");
        }

        private void button13_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // BUG FIX: Philippine mobile numbers are 11 digits (09xx-xxx-xxxx)
            if (textBox1.Text.Length < 11)
            {
                MessageBox.Show("Please enter a valid 11-digit mobile number.", "iPocket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // BUG FIX: pass both phone number AND isLogin flag to Form6
            Form6 nextScreen = new Form6(textBox1.Text, _isLogin);
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form4 prevScreen = new Form4(_isLogin);
            prevScreen.Show();
            this.Hide();
        }
    }
}
