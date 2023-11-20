namespace _213002_Q9lab7
{
    public partial class Form1 : Form
    {
        int left;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            left = textBox1.MaxLength - textBox1.TextLength;
            label2.Text = left.ToString();
        }
    }
}