using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form915 = Growth Details (savings interest details)
    public partial class Form915 : Form
    {
        public Form915()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form912 prevScreen = new Form912();
            prevScreen.Show();
            this.Hide();
        }
    }
}
