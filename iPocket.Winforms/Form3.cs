using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 nextScreen = new Form4();
            nextScreen.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}
