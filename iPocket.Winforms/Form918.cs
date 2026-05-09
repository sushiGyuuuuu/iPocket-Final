using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    // BUG FIX: Form918 was labeled "Transaction History" in comments but the
    // original Form911 routes "Send Money" (panel4) here. This is actually the
    // Send Money / Transfer screen. Renamed comments accordingly.
    // Form918 = Send Money screen (routes to Form914 for bank transfer details)
    public partial class Form918 : Form
    {
        public Form918()
        {
            InitializeComponent();
            backarrow.Click += backarrow_Click;
            // BUG FIX: label2/3/4 are filter tabs only relevant on a history screen.
            // On a Send Money screen these should be payment method selectors.
            // Kept as stubs but wired properly.
            label2.Click += label2_Click;
            label3.Click += label3_Click;
            label4.Click += label4_Click;
        }

        private void Form918_Load(object? sender, EventArgs e) { }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            Form911 prevScreen = new Form911();
            prevScreen.Show();
            this.Hide();
        }

        private void label27_Click(object? sender, EventArgs e) { }

        // BUG FIX: these were empty stubs — wire them to navigate to bank transfer (Form914)
        private void label2_Click(object? sender, EventArgs e)
        {
            // "Send to Mobile" or "All" tab — go to transfer details
            Form914 nextScreen = new Form914();
            nextScreen.Show();
            this.Hide();
        }

        private void label3_Click(object? sender, EventArgs e)
        {
            // "Bank Transfer" tab
            Form914 nextScreen = new Form914();
            nextScreen.Show();
            this.Hide();
        }

        private void label4_Click(object? sender, EventArgs e)
        {
            // "Other" tab
            Form914 nextScreen = new Form914();
            nextScreen.Show();
            this.Hide();
        }
    }
}
