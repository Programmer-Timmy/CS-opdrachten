using System.Drawing.Printing;

namespace _20_lijn
{
    public partial class Form1 : Form
    {
        List<Point> points= new List<Point>();
        Point puntA = new Point(0, 0);
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            puntA = e.Location;
            if (points.Count() < 20)
            {
                points.Add(puntA);
            }
            else
            {
                Point[] arraypoints = points.ToArray();
                Pen pen = new Pen(Color.Black, 3);
                Graphics canvas = pictureBox1.CreateGraphics();
                canvas.DrawLines(pen, arraypoints);
            }

        }
        
    }
}