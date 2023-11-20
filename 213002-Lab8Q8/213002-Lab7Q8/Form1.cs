namespace _213002_Lab7Q8
{
    public partial class Form1 : Form
    {
        private string[] imageFiles = new string[5];
        //private ArrayList arrayList = new ArrayList
       
        private int current = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imagePath = imageFiles[current];
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string folder = @"C:\\Users\\213002";
            imageFiles = Directory.GetFiles(folder, "*.png");

           foreach(string imageFile in imageFiles)
            {
                listBox1.Items.Add(imageFile);
            }

            label3.Text = listBox1.Items.Count.ToString();

            //current = listBox1.SelectedIndex;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //current =int.Parse(listView1.SelectedItems);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current = listBox1.SelectedIndex;
        }
    }
}