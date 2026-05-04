namespace iPocket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gradient_Panel2 = new Gradient_Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            gradient_Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gradient_Panel2
            // 
            gradient_Panel2.BackColor = Color.FromArgb(64, 0, 64);
            gradient_Panel2.Controls.Add(label1);
            gradient_Panel2.Controls.Add(pictureBox1);
            gradient_Panel2.Controls.Add(pictureBox2);
            gradient_Panel2.Location = new Point(1, 0);
            gradient_Panel2.Name = "gradient_Panel2";
            gradient_Panel2.Size = new Size(402, 877);
            gradient_Panel2.TabIndex = 2;
            gradient_Panel2.Paint += gradient_Panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 355);
            label1.Name = "label1";
            label1.Size = new Size(191, 61);
            label1.TabIndex = 0;
            label1.Text = "iPocket";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.iPocket_logo_removebg_preview;
            pictureBox1.Location = new Point(76, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.d6a468fe_046c_483c_8eb0_ff391080b387_removebg_preview;
            pictureBox2.Location = new Point(-15, 453);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(418, 416);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(402, 874);
            ControlBox = false;
            Controls.Add(gradient_Panel2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gradient_Panel2.ResumeLayout(false);
            gradient_Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Gradient_Panel gradient_Panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
