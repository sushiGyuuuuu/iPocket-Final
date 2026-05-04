namespace iPocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Splash screen: show for 2 seconds then go to onboarding
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                Form2 nextScreen = new Form2();
                nextScreen.Show();
                this.Hide();
            };
            timer.Start();
        }

        private void gradient_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void gradient_Panel2_Paint(object sender, PaintEventArgs e) { }
    }
}
