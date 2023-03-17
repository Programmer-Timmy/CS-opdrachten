namespace opracht_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verander de positie van de knop
            button1.Location = new Point(button1.Location.X + 50, button1.Location.Y);
        }

    }
}