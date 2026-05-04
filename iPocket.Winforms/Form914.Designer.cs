namespace iPocket
{
    partial class Form914
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // backarrow
            // 
            backarrow.BackColor = Color.Transparent;
            backarrow.Cursor = Cursors.Hand;
            backarrow.FlatAppearance.BorderSize = 0;
            backarrow.FlatStyle = FlatStyle.Flat;
            backarrow.Font = new Font("Broadway", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backarrow.ForeColor = Color.White;
            backarrow.Location = new Point(1, 39);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(84, 66);
            backarrow.TabIndex = 10;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 75);
            label1.Name = "label1";
            label1.Size = new Size(189, 40);
            label1.TabIndex = 11;
            label1.Text = "Send Money";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.send_money_profile1;
            pictureBox1.Location = new Point(95, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 341);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 13;
            label2.Text = "Recipient Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 0, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(37, 381);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter recipient name";
            textBox1.Size = new Size(318, 39);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 440);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 15;
            label3.Text = "Amount";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 0, 64);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(35, 475);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "₱ 0.00";
            textBox2.Size = new Size(320, 39);
            textBox2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(35, 556);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 75);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(189, 20);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 1;
            label5.Text = "₱ 150,000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 20);
            label4.Name = "label4";
            label4.Size = new Size(175, 30);
            label4.TabIndex = 0;
            label4.Text = "Available Balance";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 655);
            button1.Name = "button1";
            button1.Size = new Size(324, 76);
            button1.TabIndex = 18;
            button1.Text = "Send Money";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(84, 744);
            label6.Name = "label6";
            label6.Size = new Size(258, 50);
            label6.TabIndex = 19;
            label6.Text = "Your money is protected\r\nand transactions are secured.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lock_icon;
            pictureBox2.Location = new Point(53, 744);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // Form914
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(402, 874);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(backarrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form914";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form914";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backarrow;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Button button1;
        private Label label6;
        private PictureBox pictureBox2;
    }
}