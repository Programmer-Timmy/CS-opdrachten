namespace euronaarpond_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double euro = double.Parse(textBox1.Text);
            double pond = 0;
            double wissle = 0.91;

            pond = euro * wissle;

            textBox1.Text = pond.ToString();
        }
    }
}