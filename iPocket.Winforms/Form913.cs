using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form913 = Deposit screen
    public partial class Form913 : Form
    {
        public Form913()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            button1.Click += (s, e) => AddAmount(500);
            button2.Click += (s, e) => AddAmount(1000);
            button3.Click += (s, e) => AddAmount(2000);
            button4.Click += (s, e) => AddAmount(5000);
            button5.Click += button5_Click;
        }

        private void AddAmount(int amount)
        {
            if (decimal.TryParse(textBox1.Text, out decimal current))
                textBox1.Text = (current + amount).ToString();
            else
                textBox1.Text = amount.ToString();
        }

        private void button5_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(textBox1.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid deposit amount.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"Deposit of ₱{amount:N2} confirmed!", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form912 nextScreen = new Form912();
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            Form912 prevScreen = new Form912();
            prevScreen.Show();
            this.Hide();
        }
    }
}
