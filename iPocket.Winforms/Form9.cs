using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iPocket
{
    public partial class Form9 : Form
    {
        // BUG FIX: carry registration data through KYC flow
        private readonly string _fullName;
        private readonly string _password;
        private readonly string _email;
        private readonly string _pin;

        public Form9(string fullName = "", string password = "", string email = "", string pin = "")
        {
            InitializeComponent();
            _fullName = fullName;
            _password = password;
            _email    = email;
            _pin      = pin;

            backarrow.Click += backarrow_Click;
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            Form8 prevScreen = new Form8(_fullName, _password, _email);
            prevScreen.Show();
            this.Hide();
        }

        private void label32_Click(object? sender, EventArgs e) { }
        private void label1_Click(object? sender, EventArgs e) { }

        private void Form9_Load(object? sender, EventArgs e) { }
        private void panel3_Paint(object? sender, PaintEventArgs e) { }

        // BUG FIX: all three panels navigate to Form910 correctly, but they were not
        // passing the registration context. Fixed now.
        private void panel3_Click(object? sender, EventArgs e)
        {
            OpenKycUpload("Government ID");
        }

        private void panel6_Click(object? sender, EventArgs e)
        {
            OpenKycUpload("Student ID");
        }

        private void panel9_Click(object? sender, EventArgs e)
        {
            OpenKycUpload("Other IDs");
        }

        private void OpenKycUpload(string documentCategory)
        {
            Form910 nextScreen = new Form910(_fullName, _password, _email, _pin, documentCategory);
            nextScreen.Show();
            this.Hide();
        }
    }
}
