namespace opdracht_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the text from the RichTextBox
            string text = richTextBox1.Text;

            // Count the number of words and characters
            int wordCount = text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int charCount = text.Length;

            // Display the results in a MessageBox
            string message = $"Number of words: {wordCount}\nNumber of characters (including spaces): {charCount}";
            MessageBox.Show(message);
        }
    }
    }