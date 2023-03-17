namespace opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Haal de ingevoerde tekst op uit de TextBox
            string tekst = textBox1.Text;

            // Controleer of de tekst een palindroom is
            bool isPalindroom = true;
            for (int i = 0; i < tekst.Length / 2; i++)
            {
                if (tekst[i] != tekst[tekst.Length - i - 1])
                {
                    isPalindroom = false;
                    break;
                }
            }

            // Toon de resultaten in een MessageBox
            if (isPalindroom)
            {
                MessageBox.Show($"{tekst} is een palindroom.", "Palindroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{tekst} is geen palindroom.", "Geen Palindroom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}