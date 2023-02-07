namespace rekenmachine
{
    public partial class Form1 : Form
    {
        int nummerA = 0,
            nummerB = 0,
            formule = 0,
            antwoord = 0;
               
        public Form1()
        {
            InitializeComponent();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            switch(formule)
            {
                case 1:
                    antwoord = nummerB + nummerA;
                    textBox1.Text = antwoord.ToString();
                    break;
                case 2:
                    antwoord = nummerB * nummerA;
                    textBox1.Text = antwoord.ToString();
                    break;
                case 3:
                    antwoord = nummerB / nummerA;
                    textBox1.Text = antwoord.ToString();
                    break; 
                case 4:
                    antwoord = nummerB ^ nummerA;
                    textBox1.Text = antwoord.ToString();
                    break; 
                case 5:
                    antwoord = nummerB - nummerA;
                    textBox1.Text = antwoord.ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nummerA = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nummerA = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            nummerA= 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nummerA= 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nummerA= 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nummerA= 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nummerA= 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            nummerA= 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nummerA= 9;
        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            formule = 1;
            nummerB = nummerA;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            formule= 2;
            nummerB = nummerA;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            nummerB = nummerA;
            formule= 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nummerB = nummerA;
            formule= 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            nummerB = nummerA;
            formule= 5;
        }

        

    }
}