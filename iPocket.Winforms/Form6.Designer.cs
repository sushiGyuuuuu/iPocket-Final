namespace iPocket
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            backarrow = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            button11 = new Button();
            button12 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            txtOtp1 = new TextBox();
            txtOtp2 = new TextBox();
            txtOtp3 = new TextBox();
            txtOtp4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 460);
            button1.Name = "button1";
            button1.Size = new Size(289, 46);
            button1.TabIndex = 0;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 123);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 1;
            label1.Text = "Verify OTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 227);
            label2.Name = "label2";
            label2.Size = new Size(336, 64);
            label2.TabIndex = 2;
            label2.Text = "Enter the 4-digit code sent to \r\n09XX XXX XXXX\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // backarrow
            // 
            backarrow.BackColor = Color.Transparent;
            backarrow.Cursor = Cursors.Hand;
            backarrow.FlatAppearance.BorderSize = 0;
            backarrow.FlatStyle = FlatStyle.Flat;
            backarrow.Font = new Font("Broadway", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backarrow.ForeColor = Color.Black;
            backarrow.Location = new Point(-1, 94);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(84, 66);
            backarrow.TabIndex = 3;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 397);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 4;
            label3.Text = "Didn't receive code?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Purple;
            linkLabel1.Location = new Point(250, 397);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 30);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Resend";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-1, 524);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 350);
            panel1.TabIndex = 7;
            // 
            // button11
            // 
            button11.BackColor = Color.Transparent;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(275, 238);
            button11.Name = "button11";
            button11.Size = new Size(119, 64);
            button11.TabIndex = 11;
            button11.Text = "⌫";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(143, 238);
            button12.Name = "button12";
            button12.Size = new Size(126, 64);
            button12.TabIndex = 10;
            button12.Text = "0";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(275, 168);
            button8.Name = "button8";
            button8.Size = new Size(119, 64);
            button8.TabIndex = 8;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(143, 168);
            button9.Name = "button9";
            button9.Size = new Size(126, 64);
            button9.TabIndex = 7;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(14, 168);
            button10.Name = "button10";
            button10.Size = new Size(123, 64);
            button10.TabIndex = 6;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(275, 98);
            button5.Name = "button5";
            button5.Size = new Size(119, 64);
            button5.TabIndex = 5;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(143, 98);
            button6.Name = "button6";
            button6.Size = new Size(126, 64);
            button6.TabIndex = 4;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(14, 98);
            button7.Name = "button7";
            button7.Size = new Size(123, 64);
            button7.TabIndex = 3;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(275, 28);
            button4.Name = "button4";
            button4.Size = new Size(119, 64);
            button4.TabIndex = 2;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(143, 28);
            button3.Name = "button3";
            button3.Size = new Size(126, 64);
            button3.TabIndex = 1;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(14, 28);
            button2.Name = "button2";
            button2.Size = new Size(123, 64);
            button2.TabIndex = 0;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtOtp1
            // 
            txtOtp1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtp1.Location = new Point(86, 323);
            txtOtp1.MaxLength = 1;
            txtOtp1.Multiline = true;
            txtOtp1.Name = "txtOtp1";
            txtOtp1.ReadOnly = true;
            txtOtp1.Size = new Size(40, 45);
            txtOtp1.TabIndex = 8;
            txtOtp1.TextAlign = HorizontalAlignment.Center;
            txtOtp1.TextChanged += txtOtp1_TextChanged;
            // 
            // txtOtp2
            // 
            txtOtp2.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtp2.Location = new Point(143, 323);
            txtOtp2.MaxLength = 1;
            txtOtp2.Multiline = true;
            txtOtp2.Name = "txtOtp2";
            txtOtp2.ReadOnly = true;
            txtOtp2.Size = new Size(40, 45);
            txtOtp2.TabIndex = 9;
            txtOtp2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOtp3
            // 
            txtOtp3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtp3.Location = new Point(201, 323);
            txtOtp3.MaxLength = 1;
            txtOtp3.Multiline = true;
            txtOtp3.Name = "txtOtp3";
            txtOtp3.ReadOnly = true;
            txtOtp3.Size = new Size(40, 45);
            txtOtp3.TabIndex = 10;
            txtOtp3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOtp4
            // 
            txtOtp4.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOtp4.Location = new Point(257, 323);
            txtOtp4.MaxLength = 1;
            txtOtp4.Multiline = true;
            txtOtp4.Name = "txtOtp4";
            txtOtp4.ReadOnly = true;
            txtOtp4.Size = new Size(40, 45);
            txtOtp4.TabIndex = 11;
            txtOtp4.TextAlign = HorizontalAlignment.Center;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(txtOtp4);
            Controls.Add(txtOtp3);
            Controls.Add(txtOtp2);
            Controls.Add(txtOtp1);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(backarrow);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button backarrow;
        private Label label3;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Button button11;
        private Button button12;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox txtOtp1;
        private TextBox txtOtp2;
        private TextBox txtOtp3;
        private TextBox txtOtp4;
    }
}