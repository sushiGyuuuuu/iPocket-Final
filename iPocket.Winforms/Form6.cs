using System;
using System.Linq;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form6 : Form
    {
        private TextBox[] otpBoxes;

        public Form6(string phoneNumber = "")
        {
            InitializeComponent();

            otpBoxes = new TextBox[] { txtOtp1, txtOtp2, txtOtp3, txtOtp4 };

            backarrow.Click += backarrow_Click;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;

            label2.Text = $"Enter the 4-digit code sent to\n{MaskPhoneNumber(phoneNumber)}";
        }

        private void Form6_Load(object sender, EventArgs e) { }

        private void TypeNumber(string number)
        {
            foreach (TextBox box in otpBoxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = number;
                    break;
                }
            }
        }

        private string MaskPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length <= 4) return phoneNumber;
            string visible = phoneNumber.Substring(0, 4);
            string masked = new string('*', phoneNumber.Length - 4);
            return visible + masked;
        }

        private void Backspace()
        {
            foreach (TextBox box in otpBoxes.Reverse())
            {
                if (!string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "";
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verify OTP - check all boxes filled
            bool allFilled = otpBoxes.All(b => !string.IsNullOrEmpty(b.Text));
            if (!allFilled)
            {
                MessageBox.Show("Please enter the complete 4-digit OTP.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Proceed to Create Account
            Form7 nextScreen = new Form7();
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form5 prevScreen = new Form5();
            prevScreen.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Resend OTP
            foreach (TextBox box in otpBoxes) box.Text = "";
            MessageBox.Show("A new OTP has been sent to your mobile number.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtOtp1_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { TypeNumber("1"); }
        private void button3_Click(object sender, EventArgs e) { TypeNumber("2"); }
        private void button4_Click(object sender, EventArgs e) { TypeNumber("3"); }
        private void button7_Click(object sender, EventArgs e) { TypeNumber("4"); }
        private void button6_Click(object sender, EventArgs e) { TypeNumber("5"); }
        private void button5_Click(object sender, EventArgs e) { TypeNumber("6"); }
        private void button10_Click(object sender, EventArgs e) { TypeNumber("7"); }
        private void button9_Click(object sender, EventArgs e) { TypeNumber("8"); }
        private void button8_Click(object sender, EventArgs e) { TypeNumber("9"); }
        private void button12_Click(object sender, EventArgs e) { TypeNumber("0"); }
        private void button11_Click(object sender, EventArgs e) { Backspace(); }
    }
}
