namespace opdracht_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1 = "hello";
            string string2 = textBox1.Text;

            MessageBox.Show(string1 + " " + string2);
        }
    }
}