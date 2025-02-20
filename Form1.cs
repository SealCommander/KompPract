namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int num_rand;
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            num_rand = rand.Next(0, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            if (num > num_rand)
            {
                label1.Text = "Меньше";
            }
            else if (num < num_rand)
            {
                label1.Text = "Больше";
            }
            else
            {
                label1.Text = "Ура";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
