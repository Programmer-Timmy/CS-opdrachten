using System.Globalization;

namespace verguningaanvraag
{
    public partial class Form1 : Form
    {
        int vraag = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vraag == 0)
            {
                if (textBox1.Text == "ja")
                {
                    textBox1.Text = "";
                    textBox2.Text = "verlichting?";
                    vraag = 1;
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "apv?";
                    vraag = 2;
                }
            }
            if (vraag == 1)
            {
                if (textBox1.Text == "ja")
                {
                    textBox1.Text = "";
                    textBox2.Text = "top!";
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "oops!";
                }
            }
            if (vraag == 2)
            {
                if (textBox1.Text == "ja")
                {
                    textBox1.Text = "";
                    textBox2.Text = "geen!";
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "Omgeving";

                }
            }
        }
    }
}