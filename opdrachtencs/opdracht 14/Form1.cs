namespace opdracht_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 34, 543, 1, -1, 34, 54, 65, 234, 546, 66, 91, 345, 45 };

            int highest = numbers[0];
            int last = numbers[numbers.Length - 1];
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }
            }

            double average = sum / numbers.Length;
            int totalSum = numbers.Sum();
            Array.Sort(numbers);

            string result = "Hoogste waarde: " + highest + Environment.NewLine +
                            "Laatste waarde: " + last + Environment.NewLine +
                            "Gemiddelde: " + average + Environment.NewLine +
                            "Som van alle waardes: " + totalSum + Environment.NewLine +
                            "Array gesorteerd van laag naar hoog: " + string.Join(", ", numbers);

            MessageBox.Show(result, "Array informatie");
        }

    }
}