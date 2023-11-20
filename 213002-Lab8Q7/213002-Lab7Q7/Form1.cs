namespace _213002_Lab7Q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime obj = DateTime.Today;
            string formattedDate =obj.ToString("MMMM dd, yyyy");
            string day = obj.ToString("dddd");
            label1.Text = day + " , " + formattedDate;

            string formattedTime = obj.ToString("h:mm:ss tt");
            label2.Text = formattedTime;
        }
    }
}