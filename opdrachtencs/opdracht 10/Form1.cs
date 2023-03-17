namespace opdracht_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            private void button1_Click(object sender, EventArgs e)
            {
                for (int teller = 10; teller >= 1; teller--)
                {
                    MessageBox.Show($"Teller: {teller}", "Tellerwaarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        
    }
}