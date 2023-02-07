namespace workshop2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity= (float)trackBar1.Value / 100;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGoldenrodYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mijnform = new Form2(textBox1.Text);



            mijnform.ShowDialog();
        }
    }
}