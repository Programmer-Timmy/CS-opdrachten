namespace opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om een getal
            int getal = int.Parse(numericUpDown1.Text);

            // Bereken het aantal dozijnen en restanten
            int dozijnen = getal / 12;
            int restant = getal % 12;

            // Toon de resultaten in afzonderlijke MessageBoxen
            MessageBox.Show($"Het ingevulde getal kan worden omgezet in {dozijnen} dozijn(en)");
            MessageBox.Show($"Er blijven nog {restant} over");
        
    }
}