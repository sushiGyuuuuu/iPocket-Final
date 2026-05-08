namespace iPocket
{
    partial class Form920
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
            label3 = new Label();
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
            backarrow.Location = new Point(1, 63);
            backarrow.Name = "backarrow";
            backarrow.Size = new Size(84, 77);
            backarrow.TabIndex = 1;
            backarrow.Text = "←";
            backarrow.TextAlign = ContentAlignment.TopLeft;
            backarrow.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 103);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 2;
            label1.Text = "Enter Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 278);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 3;
            label2.Text = "Email address";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(30, 323);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "name@gmail.com";
            textBox1.Size = new Size(333, 39);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 199);
            label3.Name = "label3";
            label3.Size = new Size(374, 32);
            label3.TabIndex = 5;
            label3.Text = "We'll send you a verification code";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(63, 754);
            button1.Name = "button1";
            button1.Size = new Size(269, 46);
            button1.TabIndex = 6;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form920
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 874);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backarrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form920";
            Text = "Form920";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backarrow;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}