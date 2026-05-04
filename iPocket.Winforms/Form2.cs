using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Wire Get Started button
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 nextScreen = new Form3();
            nextScreen.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
