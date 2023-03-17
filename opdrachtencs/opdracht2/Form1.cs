namespace opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string string1= "Hallo";
            string string2 = "ik ben een programmeur";

            MessageBox.Show(string1+ " " + string2);
        }
    }
}