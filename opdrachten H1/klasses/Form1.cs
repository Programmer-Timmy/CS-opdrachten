using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace klasses
{
    
    public partial class Form1 : Form


    {

        public Form1()
        {
            InitializeComponent();
        }

        class Rechthoek
        {
            private Point puntA = new Point(50, 50);
            private int Lengte = 0;
            private int Breedte = 0;
            PictureBox Canvas;

            public Rechthoek(int lengte, int breedte, PictureBox picture)
            {
                Lengte = lengte;
                Breedte = breedte;
                Canvas = picture;
            }

            public double oppervlakte()
            {
                return Lengte * Breedte;
            }
            public double omtrek()
            {
                return (2 * Lengte) + (2 * Breedte);
            }
            public void draw(int lijndikte, Color kleur, Point puntA)
            {
                Graphics papier = Canvas.CreateGraphics();
                Pen tekenpotlood = new Pen(kleur, lijndikte) ;

                papier.DrawLine(tekenpotlood, puntA.X, puntA.Y, (puntA.X + Lengte), puntA.Y);
                papier.DrawLine(tekenpotlood, (puntA.X + Lengte), puntA.Y, (puntA.X + Lengte), (puntA.Y + Breedte));
                papier.DrawLine(tekenpotlood, (puntA.X + Lengte), (puntA.Y + Breedte), puntA.X, (puntA.Y + Breedte));
                papier.DrawLine(tekenpotlood, puntA.X, (puntA.Y + Breedte), puntA.X, puntA.Y);
            }
        }

        Point puntA = new Point(0, 0);
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            puntA = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lengte = int.Parse(textBox1.Text);
            int breete = int.Parse(textBox2.Text);
            colorDialog1.ShowDialog();
            Rechthoek r = new Rechthoek(lengte,breete, pictureBox1);
            label1.Text = "omtrek = " + r.omtrek().ToString();
            label2.Text = "oppervlak = " +r.oppervlakte().ToString();
            Color kleur = colorDialog1.Color;
            r.draw(int.Parse(textBox3.Text), kleur, puntA);
        }

        
    }
    
}