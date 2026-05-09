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
        // BUG FIX: track whether this is a login or registration flow
        private readonly bool _isLogin;

        public Form4(bool isLogin = false)
        {
            InitializeComponent();
            _isLogin = isLogin;
            button1.Click += button1_Click;   // Use Mobile Number
            button2.Click += button2_Click;   // Continue with Apple
            linkLabel1.LinkClicked += linkLabel1_LinkClicked; // Login / Sign up toggle
            UpdateLoginRegisterLink();
        }

        private void UpdateLoginRegisterLink()
        {
            // BUG FIX: show correct link text depending on flow direction
            linkLabel1.Text = _isLogin ? "Don't have an account? Sign up" : "Already have an account? Log in";
        }

        private void Form4_Load(object? sender, EventArgs e) { }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Use Mobile Number -> Enter mobile number screen
            Form5 nextScreen = new Form5(_isLogin);
            nextScreen.Show();
            this.Hide();
        }

        private void button2_Click(object? sender, EventArgs e)
        {
            // Continue with Apple -> same mobile number entry flow
            Form5 nextScreen = new Form5(_isLogin);
            nextScreen.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            // Toggle between login and registration
            Form4 toggled = new Form4(!_isLogin);
            toggled.Show();
            this.Hide();
        }

        private void label5_Click(object? sender, EventArgs e) { }
    }
}
