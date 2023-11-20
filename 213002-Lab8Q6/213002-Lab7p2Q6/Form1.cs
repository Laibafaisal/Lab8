namespace _213002_Lab7p2Q6
{
    public partial class Form1 : Form
    {
        private int TotalTime;
        private int remaining;
        public Form1()
        {
            InitializeComponent();
            TotalTime = remaining = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            timer2.Enabled = false;
            label3.Visible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TotalTime = (int)numericUpDown1.Value;
            remaining = TotalTime;
            Updatetime();
            timer2.Enabled = true;
            timer2.Start();
            numericUpDown1.Enabled = false;
            button1.Enabled = false;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            remaining--;
            Updatetime();
            if (remaining == 0)
            {
                timer2.Stop();
                MessageBox.Show("Time's Up!!!");
                numericUpDown1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void Updatetime()
        {
            label3.Visible = true;
            label3.Text = remaining.ToString();
        }

    }
}