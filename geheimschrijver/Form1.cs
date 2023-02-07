namespace geheimschrijver
{
    public partial class Form1 : Form
    {
        string secret = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int code = (int)e.KeyChar;
            int code2 = code + 8;
            char letter = (char)code2;
            secret = secret + letter.ToString();
            richTextBox1.Text = secret;
        }
    }
}