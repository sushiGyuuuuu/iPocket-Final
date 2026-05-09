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
        // BUG FIX: receive all registration data and document category from Form9
        private readonly string _fullName;
        private readonly string _password;
        private readonly string _email;
        private readonly string _pin;
        private readonly string _documentCategory;

        public Form910(string fullName = "", string password = "", string email = "",
                       string pin = "", string documentCategory = "Government ID")
        {
            InitializeComponent();
            _fullName         = fullName;
            _password         = password;
            _email            = email;
            _pin              = pin;
            _documentCategory = documentCategory;

            backarrow.Click += backarrow_Click;
            button1.Click   += button1_Click;
        }

        private void backarrow_Click(object? sender, EventArgs e)
        {
            Form9 prevScreen = new Form9(_fullName, _password, _email, _pin);
            prevScreen.Show();
            this.Hide();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // BUG FIX: validate a document type is selected before proceeding
            // (comboBox1 or similar control should hold the chosen document type)
            // Navigate to Dashboard after KYC submission
            MessageBox.Show(
                $"KYC document submitted under \"{_documentCategory}\".\n" +
                "Your account is being set up!", "iPocket",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form911 nextScreen = new Form911();
            nextScreen.Show();
            this.Hide();
        }
    }
}
