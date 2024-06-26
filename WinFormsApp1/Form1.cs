using System.Drawing.Imaging;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Start();
            t.Interval = 1000;
            t.Tick += T_Tick;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            if (button1.Text == "Baku")
                label1.Text = DateTime.Now.ToString();
            else if (button1.Text == "London")
                label1.Text = DateTime.Now.AddHours(-3.0).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = -3;
            if (button1.Text == "Baku")
            {
                string text = "download (1).jpg";
                button1.Text = "London";
                label1.Text = DateTime.Now.AddHours(a).ToString();

                Image i = Image.FromFile(text);
                pictureBox1.BackgroundImage = i;

            }
            else if (button1.Text == "London")
            {
                string text = "download.jpg";
                button1.Text = "Baku";
                label1.Text = DateTime.Now.ToString();
                Image image = Image.FromFile(text);
                pictureBox1.BackgroundImage = image;
            }
        }

    }
}