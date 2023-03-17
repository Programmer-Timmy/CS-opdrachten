namespace opdracht_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\tmp\myfile.txt";
            string text = textBox1.Text;

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }

            MessageBox.Show("De tekst is opgeslagen in " + path);
        }
    }
}