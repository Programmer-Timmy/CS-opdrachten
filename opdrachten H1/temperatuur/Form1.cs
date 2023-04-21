namespace temperatuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int celcius = int.Parse(textBox1.Text);
            int Kelvin = (int)(273.15 - celcius);

            textBox2.Text = Kelvin.ToString();
        }
    }
}