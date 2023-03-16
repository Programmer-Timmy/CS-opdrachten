using System.Security.Cryptography.X509Certificates;

namespace kutzooi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           car p1 = new car();
            p1.merk = "test";
            p1.type = "jeweetwel";
            p1.bouwjaar = 2001;
            p1.show();

        }
    }
}