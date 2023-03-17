using System.Media;

namespace opdraht_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Maak een nieuw SoundPlayer object aan met het pad naar het audiobestand
            SoundPlayer player = new SoundPlayer(@"C:\Users\Timva\OneDrive - ROC Midden Nederland\Documenten\levels\level 4\code\portfolio-git\project\duckhunt\sounds\duck.wav");

            // Speel het audiobestand af
                player.Play();
        }

    }
}