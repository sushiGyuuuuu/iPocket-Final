using System;
using System.Linq;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form6 : Form
    {
        private TextBox[] otpBoxes;

        public Form6()
        {
            InitializeComponent();

            otpBoxes = new TextBox[] { txtOtp1, txtOtp2, txtOtp3, txtOtp4 };
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void TypeNumber(string number)
        {
            // Loop through your array of textboxes
            foreach (TextBox box in otpBoxes)
            {
                // Find the first box that is completely empty
                if (string.IsNullOrEmpty(box.Text))
                {
                    // Put the number in and stop looking
                    box.Text = number;
                    break;
                }
            }
        }
        private void Backspace()
        {
            // Look through your textboxes in reverse order (Box 4, then 3, 2, 1)
            foreach (TextBox box in otpBoxes.Reverse())
            {
                // Find the first one that actually has a number in it
                if (!string.IsNullOrEmpty(box.Text))
                {
                    // Erase the number and stop looking
                    box.Text = "";
                    break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtOtp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeNumber("1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TypeNumber("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeNumber("3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TypeNumber("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TypeNumber("5");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TypeNumber("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TypeNumber("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TypeNumber("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TypeNumber("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TypeNumber("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Backspace();
        }
    }
}
