namespace opdracht_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bestandspad en -naam
            string filePath = @"c:\tmp\myfile.txt";

            // Controleer of het bestand bestaat
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Het bestand bestaat niet.");
                return;
            }

            // Lees de inhoud uit van het bestand
            string fileContents = File.ReadAllText(filePath);

            // Toon de inhoud in een MessageBox
            MessageBox.Show(fileContents);
        }

    }
}