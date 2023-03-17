namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getal1 = 10;
            int getal2 = 20;

            int getal3 = getal1 + getal2;
            int getal4 = getal1 * getal2;
            int getal5 = getal1 / getal2;
            MessageBox.Show(getal3.ToString());
            MessageBox.Show(getal4.ToString());
            MessageBox.Show(getal5.ToString());

        }
    }
}