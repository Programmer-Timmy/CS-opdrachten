using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NatSim
{
    public class Gras
    {
        private Size _afmetingen = new Size(2,4);
        private Bloeiwijze _bloeiwijzePlant = Bloeiwijze.aar;
        private Color _kleur = Color.LawnGreen;
        private string _latijnsenaam = "gramineae";
        private int _leeftijd;
        private int _levensduur = 4;
        private Point _locatie= new Point();
        private string _nederlandseNaam = "Gras";
        private Timer _verouder = new Timer();
        private bool _verwijderd = false;
        private int _voedingswaarde = 1;

        public Size afmetingen 
        { 
            get   { return _afmetingen; } 
        }
        public Bloeiwijze bloeiwijzePlant
        {
            get { return _bloeiwijzePlant; }
        }
        public Color Kleur
        {
            get { return _kleur; }
        }
        public string latijnsenaam
        {
            get { return _latijnsenaam;}
        }
        public int leeftijd 
        { 
            get { return _levensduur;}
            set { _levensduur = value; }
        }
        public int levensduur
        { 
            get { return _levensduur;} 
        }
        public Point Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }
        public string nederlandsenaam
        {
            get { return _nederlandseNaam; }
        }
        public Timer verouder
        {
            get { return _verouder; }
        }
        public bool verwijdert
        {
            get { return _verwijderd; }
        }
        public int voedingswaarde
        {
            get { return _voedingswaarde; }
        }

        public void Verwijder()
        {
            _verwijderd = true;
        }

        public void Teken(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black, 2);

            int starthoogte = Locatie.Y - afmetingen.Height;

            graphics.DrawRectangle(pen, Locatie.X, starthoogte, afmetingen.Width, afmetingen.Height);

            pen.Dispose();

            SolidBrush kwast = new SolidBrush(Kleur);
            graphics.FillRectangle(kwast, Locatie.X, starthoogte, afmetingen.Width, afmetingen.Height);

            kwast.Dispose();

        }

        private void initClass(Point locatie)
        {
            Locatie = locatie;
            verouder.Start();
        }

        public Gras(Point locatie)
        {
            initClass(locatie);
        }
    }

    
}
