namespace opdaracht_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int teller = 1;
            while (teller <= 10)
            {
                MessageBox.Show($"Teller: {teller}", "Tellerwaarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teller++;
            }
        }
    }
}