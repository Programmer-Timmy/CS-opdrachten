namespace kleuren_wisselaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left )
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.Blue;
            }
        }
    }
}