namespace opdracht_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Maak een nieuw formulier aan en toon dit met de Show() methode
            Form newForm = new Form();
            newForm.Text = "Nieuw formulier (Show)";
            newForm.ShowDialog();

    }
}