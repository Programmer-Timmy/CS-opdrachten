namespace oppervlakteh9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double lengte = double.Parse(textBox1.Text);
            double breete = double.Parse(textBox2.Text);

            double oppervlak = lengte* breete;

            MessageBox.Show(oppervlak.ToString());
        }
    }
}