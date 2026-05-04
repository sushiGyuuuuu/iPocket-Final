using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form914 = Send Money / Bank Transfer details
    public partial class Form914 : Form
    {
        public Form914()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Transfer submitted successfully!", "iPocket", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form911 nextScreen = new Form911();
            nextScreen.Show();
            this.Hide();
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form918 prevScreen = new Form918();
            prevScreen.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
