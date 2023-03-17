namespace opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om een getal
            var getal = numericUpDown1.Value;

            // Controleer of het getal even of oneven is
            if (getal % 2 == 0)
            {
                // Het getal is even
                MessageBox.Show("HET GETAL IS EVEN");
            }
            else
            {
                // Het getal is oneven
                MessageBox.Show("HET GETAL IS ONEVEN");
            }
        }
    }
}