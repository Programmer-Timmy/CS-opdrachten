namespace opdracht_11
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

            for (int i = 0; i < automerken.Length; i++)
            {
                MessageBox.Show(automerken[i], "Automerk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}