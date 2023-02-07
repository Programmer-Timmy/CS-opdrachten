using Microsoft.VisualBasic;

namespace datum_tijd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime theDate = dateTimePicker1.Value;
            int day = (int)theDate.DayOfWeek;
            switch (day)
            {
                case 1:
                    MessageBox.Show("maandag");
                    break;
                case 2:
                    MessageBox.Show("dinsdag");
                    break;
                case 3:
                    MessageBox.Show("woensdag");
                    break;
                case 4:
                    MessageBox.Show("donderdag");
                    break;
                case 5:
                    MessageBox.Show("vrijdag");
                    break;
                case 6:
                    MessageBox.Show("zaterdag");
                    break;
                case 7:
                    MessageBox.Show("Zondag");
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = dateTimePicker1.Value;
            string year = today.Year.ToString();
            MessageBox.Show(year);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string month = date.Month.ToString();
            MessageBox.Show(month);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string month_name = date.ToString("MMMM");
            MessageBox.Show(month_name);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string month_name = date.ToString("MMM");
            MessageBox.Show(month_name);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            TimeSpan interval = date - DateTime.Now;

            var days = interval.Days / 356.25;
            MessageBox.Show(days.ToString());

        }
    }
}