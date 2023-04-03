namespace opdracht_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var getal = numericUpDown1.Value;
             
            switch (getal)
            {
                case < 100:
                    MessageBox.Show("laag");
                    break;

                case > 100:
                    MessageBox.Show("hoog");
                    break;

                case 100:
                    MessageBox.Show("100");
                    break;

                

            };
        }
    }
}
        
