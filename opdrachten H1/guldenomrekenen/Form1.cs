namespace guldenomrekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dateTimePicker1.Text);
            var now = date.Year;
            now = now % 19 + 1;
            MessageBox.Show(now.ToString());
        }
    }
}