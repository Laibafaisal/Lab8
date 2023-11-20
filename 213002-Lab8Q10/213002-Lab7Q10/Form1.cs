namespace _213002_Lab7Q10
{
    public partial class Form1 : Form
    {
        int token1 = 0;
        int token2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            token1++;
            textBox1.Text = token1.ToString();
            label3.Text = (token2-token1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            token2++;
            label6.Text = token2.ToString();
            label3.Text = (token2 - token1).ToString();
        }
    }
}