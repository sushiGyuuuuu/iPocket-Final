namespace iPocket
{
    partial class Form913
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            backarrow.Location = new Point(-1, 39);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(84, 66);
            backarrow.TabIndex = 9;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 65);
            label1.Name = "label1";
            label1.Size = new Size(122, 40);
            label1.TabIndex = 10;
            label1.Text = "Deposit";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.deposit;
            pictureBox1.Location = new Point(131, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 319);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 12;
            label2.Text = "Enter Amount";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 0, 64);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(38, 356);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "₱ 0.00";
            textBox1.Size = new Size(324, 39);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 436);
            label3.Name = "label3";
            label3.Size = new Size(168, 32);
            label3.TabIndex = 14;
            label3.Text = "Quick Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 7.125F);
            button1.Location = new Point(29, 481);
            button1.Name = "button1";
            button1.Size = new Size(68, 38);
            button1.TabIndex = 15;
            button1.Text = "+500";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 7.125F);
            button2.Location = new Point(103, 481);
            button2.Name = "button2";
            button2.Size = new Size(87, 38);
            button2.TabIndex = 16;
            button2.Text = "+1,000";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.125F);
            button3.Location = new Point(196, 481);
            button3.Name = "button3";
            button3.Size = new Size(88, 38);
            button3.TabIndex = 17;
            button3.Text = "+2,000\r\n";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 7.125F);
            button4.Location = new Point(290, 481);
            button4.Name = "button4";
            button4.Size = new Size(88, 38);
            button4.TabIndex = 18;
            button4.Text = "+5,000\r\n";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Indigo;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(47, 593);
            button5.Name = "button5";
            button5.Size = new Size(305, 46);
            button5.TabIndex = 19;
            button5.Text = "Confirm Deposit";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(26, 695);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 71);
            panel1.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(217, 19);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 1;
            label5.Text = "₱ 150,000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 21);
            label4.Name = "label4";
            label4.Size = new Size(175, 30);
            label4.TabIndex = 0;
            label4.Text = "Available Balance";
            // 
            // Form913
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(402, 874);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(backarrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form913";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label label5;
        private Label label4;
    }
}