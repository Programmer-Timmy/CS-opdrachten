namespace verticaal
{
    public partial class Form1 : Form
    {
        int tussen = 0;
        Point puntA = new Point(0,0);
        PointF puntAF = new Point(0, 0);

        Point puntB = new Point(0,0);
        int aantalklikken = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen tekenpotlood = new Pen(Color.Blue, 4);

            Graphics papier = pictureBox1.CreateGraphics();

            int x = 10;
            int y = 10;
            int count = 0;

            while (count < 20)
            {
                papier.DrawLine(tekenpotlood, x, 10, y, 200);
                x += 10;
                y += 10;
                count++;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen tekenpotlood = new Pen(Color.Blue, 4);

            Graphics papier = pictureBox1.CreateGraphics();

            int x = 10;
            int y = 10;
            int count = 0;

            while (count < 20)
            {
                papier.DrawLine(tekenpotlood, 10, x, 200, y);
                x += 10;
                y += 10;
                count++;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vScrollBar1.Value = tussen;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tussen = vScrollBar1.Value;
            textBox3.Text = vScrollBar1.Value.ToString();
            pictureBox1.Refresh();
            print();



        }

        private void print()
        {
            
            Pen tekenpotlood = new Pen(colorDialog1.Color, 4);

            Graphics papier = pictureBox1.CreateGraphics();

            tussen = int.Parse(textBox3.Text);

            int x = tussen;
            int y = tussen;
            int count = 1;
            int x2 = tussen;
            int y2 = tussen;

            int aantal1 = int.Parse(textBox1.Text);
            int aantal2 = int.Parse(textBox2.Text);

            while (count <= aantal1)
            {
                papier.DrawLine(tekenpotlood, 10, x, 200, y);

                x += tussen;
                y += tussen;

                count++;
            }

            count = 1;

            while (count <= aantal2)
            {
                papier.DrawLine(tekenpotlood, x2, 10, y2, 200);
                x2 += tussen;
                y2 += tussen;
                count++;
            }


        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Pen tekenpotlood = new Pen(colorDialog1.Color, 4);
            Graphics papier = pictureBox1.CreateGraphics();

            if (aantalklikken == 0)
            {
                aantalklikken = 1;

                puntA = e.Location;
            }
            else
            {
                aantalklikken = 0;
                puntB = e.Location;
                papier.DrawLine(tekenpotlood, puntA, puntB);
            }

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int breete = int.Parse(textBox4.Text);
            int hoogte = int.Parse(textBox5.Text);

            


            Pen tekenpotlood = new Pen(colorDialog1.Color, 4);

            Graphics papier = pictureBox1.CreateGraphics();

            if (checkBox1.Checked == false)
            {

                papier.DrawLine(tekenpotlood, puntA.X, puntA.Y, (puntA.X + breete), puntA.Y);
                papier.DrawLine(tekenpotlood, puntA.X, (puntA.Y + hoogte), puntA.X, puntA.Y);
                papier.DrawLine(tekenpotlood, puntA.X, (puntA.Y + hoogte), (puntA.X + breete), (puntA.Y + hoogte));
                papier.DrawLine(tekenpotlood, (puntA.X + breete), (puntA.Y + hoogte), (puntA.X + breete), puntA.Y);
                papier.DrawLine(tekenpotlood, puntA.X, puntA.Y, (puntA.X + breete), (puntA.Y + breete));
                Rectangle r = new Rectangle(puntA.X, puntA.Y, breete, hoogte);
                papier.DrawEllipse(tekenpotlood, r);
            } else
            {
                papier.DrawBezier(tekenpotlood, puntA, new Point((puntA.X + (breete / 3)), (puntA.Y + (hoogte / 3))), new Point((puntA.X + 2 * (breete / 3)), (puntA.Y - (hoogte / 3))), new Point((puntA.X + breete), puntA.Y));

            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
        
