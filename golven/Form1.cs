namespace golven
{
    public partial class Form1 : Form
    {
        Point puntA;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
                puntA = e.Location;
                int L = int.Parse(textBox4.Text);
                int B = int.Parse(textBox5.Text);
                Graphics papier = pictureBox1.CreateGraphics();
                Pen tekenpotlood = new Pen(Color.Black, 4);

                if (checkBox1.Checked == false)
                {


                    papier.DrawLine(tekenpotlood, puntA.X, puntA.Y, (puntA.X + L), puntA.Y);
                    papier.DrawLine(tekenpotlood, (puntA.X + L), puntA.Y, (puntA.X + L), (puntA.Y + B));
                    papier.DrawLine(tekenpotlood, (puntA.X + L), (puntA.Y + B), puntA.X, (puntA.Y + B));
                    papier.DrawLine(tekenpotlood, puntA.X, (puntA.Y + B), puntA.X, puntA.Y);
                    papier.DrawLine(tekenpotlood, puntA.X, puntA.Y, (puntA.X + L), (puntA.Y + B));
                    Rectangle r = new Rectangle(puntA.X, puntA.Y, L, B);

                    papier.DrawEllipse(tekenpotlood, r);

                }
                else
                {
                    papier.DrawBezier(tekenpotlood, puntA, new Point((puntA.X + (L / 3)), (puntA.Y + (B / 3))), new Point((puntA.X + 2 * (L / 3)), (puntA.Y - (B / 3))), new Point((puntA.X + L), puntA.Y));
                }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}