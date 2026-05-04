namespace iPocket
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dot3 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 500);
            label1.Name = "label1";
            label1.Size = new Size(377, 36);
            label1.TabIndex = 0;
            label1.Text = "Making Saving a Habit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 565);
            label2.Name = "label2";
            label2.Size = new Size(364, 64);
            label2.TabIndex = 1;
            label2.Text = "Nurture your savings and \r\nwatch it grow over time.\r\n";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = Color.White;
            button1.Location = new Point(220, 784);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Get Started";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.plant;
            pictureBox1.Location = new Point(-60, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 469);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // dot3
            // 
            dot3.BackColor = Color.DarkGray;
            dot3.Location = new Point(42, 791);
            dot3.Name = "dot3";
            dot3.Size = new Size(20, 20);
            dot3.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.MediumPurple;
            label3.Location = new Point(90, 791);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(label3);
            Controls.Add(dot3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label dot3;
        private Label label3;
    }
}