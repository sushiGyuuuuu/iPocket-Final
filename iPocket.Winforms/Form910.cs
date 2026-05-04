using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form910 : Form
    {
        public Form910()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            button1.Click += button1_Click;
        }

        private void backarrow_Click(object sender, EventArgs e)
        {
            Form9 prevScreen = new Form9();
            prevScreen.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Continue to Dashboard/Home
            Form911 nextScreen = new Form911();
            nextScreen.Show();
            this.Hide();
        }
    }
}
