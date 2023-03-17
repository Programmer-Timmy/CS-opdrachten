namespace opdracht_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                MessageBox.Show($"Teller: {i}", "Tellerwaarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}