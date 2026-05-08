using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Click += button1_Click;   // Use Mobile Number
            button2.Click += button2_Click;   // Continue with Apple
            linkLabel1.LinkClicked += linkLabel1_LinkClicked; // Login
        }

        private void Form4_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // Use Mobile Number -> Enter mobile number screen
            Form5 nextScreen = new Form5();
            nextScreen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Continue with Apple -> same flow for now
            Form5 nextScreen = new Form5();
            nextScreen.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Login -> go to mobile number entry (login flow)
            Form5 nextScreen = new Form5();
            nextScreen.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
