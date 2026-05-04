namespace iPocket
{
    partial class Form7
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
            backarrow = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // backarrow
            // 
            backarrow.BackColor = Color.Transparent;
            backarrow.Cursor = Cursors.Hand;
            backarrow.FlatAppearance.BorderSize = 0;
            backarrow.FlatStyle = FlatStyle.Flat;
            backarrow.Font = new Font("Broadway", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backarrow.ForeColor = Color.Black;
            backarrow.Location = new Point(1, 41);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(62, 66);
            backarrow.TabIndex = 7;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 91);
            label1.Name = "label1";
            label1.Size = new Size(278, 37);
            label1.TabIndex = 8;
            label1.Text = "Create Your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 172);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 9;
            label2.Text = "Full Name";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(41, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 39);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(41, 336);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 39);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 293);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 11;
            label3.Text = "Email Address";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(41, 462);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 39);
            textBox3.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 419);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 13;
            label4.Text = "Create Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.125F);
            label5.Location = new Point(56, 539);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 15;
            label5.Text = "○ At least 8 characters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.125F);
            label6.Location = new Point(56, 571);
            label6.Name = "label6";
            label6.Size = new Size(193, 25);
            label6.TabIndex = 16;
            label6.Text = "○ Contains a number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.125F);
            label7.Location = new Point(56, 603);
            label7.Name = "label7";
            label7.Size = new Size(269, 25);
            label7.TabIndex = 17;
            label7.Text = "○ Contains a special character";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 709);
            button1.Name = "button1";
            button1.Size = new Size(334, 73);
            button1.TabIndex = 18;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backarrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backarrow;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}