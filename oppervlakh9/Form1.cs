namespace oppervlakh9
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

            double oppervlak = Math.Pow(lengte, 2) * Math.Pow(breete,2 );

            MessageBox.Show(oppervlak.ToString());
        }
    }
}