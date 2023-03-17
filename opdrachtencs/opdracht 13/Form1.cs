namespace opdracht_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cars = { "Volvo", "Saab", "Opel", "Mercedes", "BMW", "Renault" };

            string output = "";

            for (int i = cars.Length - 1; i >= 0; i--)
            {
                output += cars[i] + "\n";
            }

            MessageBox.Show(output, "Cars in reverse order");
        }

    }
}