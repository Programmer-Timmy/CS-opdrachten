namespace opdracht_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] automerken = { "Volvo", "Saab", "Opel", "Mercedes", "BMW", "Renault" };

            string message = "Automerk(en):\n";
            foreach (string merk in automerken)
            {
                message += merk + "\n";
            }
            MessageBox.Show(message);
        }

    }
}