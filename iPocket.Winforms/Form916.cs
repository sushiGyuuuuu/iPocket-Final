using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // Form916 = Transaction History / Growth Details (Interest breakdown)
    public partial class Form916 : Form
    {
        public Form916()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            Form911 prevScreen = new Form911();
            prevScreen.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e) { }
    }
}
