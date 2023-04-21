using System.Windows.Forms;

namespace h8_v_1_2
{
    public partial class Form1 : Form
    {
        private Control txbGetal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e, string regel)
        {
            int[] temp = { -40, -33, -22, -11, -1, 10, 20, 22, 28, 32, 35, 38, 39, 40, 50 };

            int[] prijzen = { 0, 200, 400, 1000, 100000 };

            string[] namen = { "jan", "piet", "karel", "jan2" };

            Console.WriteLine(temp[6]);
            Console.WriteLine(namen[0]);

            int regelnummer = 0;
            try
            {
                regelnummer = int.Parse(Console.ReadLine());
            }
            catch (Exception exceptation)
            {
                
                ErrorProvider.SetError(textBox1, exceptation.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}