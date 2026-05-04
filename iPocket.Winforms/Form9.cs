using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace iPocket
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form8 prevScreen = new Form8();
            prevScreen.Show();
            this.Hide();
        }

        private void label32_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void Form9_Load(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form910 nextScreen = new Form910();
            nextScreen.Show();
            this.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Form910 nextScreen = new Form910();
            nextScreen.Show();
            this.Hide();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Form910 nextScreen = new Form910();
            nextScreen.Show();
            this.Hide();
        }
    }
}
