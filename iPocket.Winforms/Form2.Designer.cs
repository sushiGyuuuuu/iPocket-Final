namespace iPocket
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dot1 = new Label();
            dot2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.piggy_bank_removebg_preview;
            pictureBox1.Location = new Point(12, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 493);
            label1.Name = "label1";
            label1.Size = new Size(393, 36);
            label1.TabIndex = 1;
            label1.Text = "Your Savings, Growing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 551);
            label2.Name = "label2";
            label2.Size = new Size(349, 135);
            label2.TabIndex = 2;
            label2.Text = "Start small, stay consistent, \r\nand achive your goals by \r\ntracking your savings and \r\nmaking smart choices \r\nfor your future.\r\n";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = Color.White;
            button1.Location = new Point(234, 796);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Get Started";
            button1.UseVisualStyleBackColor = false;
            // 
            // dot1
            // 
            dot1.BackColor = Color.MediumPurple;
            dot1.ImageAlign = ContentAlignment.MiddleRight;
            dot1.Location = new Point(58, 803);
            dot1.Name = "dot1";
            dot1.Size = new Size(20, 20);
            dot1.TabIndex = 4;
            // 
            // dot2
            // 
            dot2.BackColor = Color.DarkGray;
            dot2.Location = new Point(104, 804);
            dot2.Name = "dot2";
            dot2.Size = new Size(20, 20);
            dot2.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(dot2);
            Controls.Add(dot1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label dot1;
        private Label dot2;
    }
}