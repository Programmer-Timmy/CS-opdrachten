using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Drawing.Drawing2D;

namespace NatSim
{
    public class konijn
    {
        // Private variabelen
        //
        // Algemene gegevens
        //
        private string _latijnseNaam = "Oryctolagus cuniculus"; // laatijnse naam van de soort
        private string _nederlandseNaam = "konijn"; // naam van de soort
        private double _gewichtMaximaal = 5; // maximaal gewicht van een konijn in kg
        private int _levensduur = 9; // de maximalen levensduur van een konijn in jaren
        private List<string> _wordtVergiftigdDoor = new List<string>() {"venijnboom", "Vingerhoedskruid"}; // Een lijst met planten die giftig zijn voor een konijn

        //
        // objectspecifieke gegevens
        //

        private string _naam = "flappie"; // De naam van een konijn

        private double _gewicht = 3; // gewicht van konijn
        private int _maagGevuld = 0; // hoeveel procent is de maag gevult
        private int _voedingswaarde = 0; // hoeveel voedingswaarde heeft het konijn
        private Timer _verouder = new Timer(1000); //Flappie wordt ouder: 1000 ticks = 1 sec = 1 jaar

        private int _leeftijd = 0; // de leeftijd
        private DateTime _geboortedatum; // geboorte
        private DateTime _sterfdatum; // datum gestoorve

        //
        // Grafische informatie
        //

        private Size _afmetingen = new Size(10, 10);

        private bool _verwijderd = false; // is verwijderd?
        private Color _kleur = Color.Brown; // de kleur
        private Point _locatie = new Point(0, 0); //waar is hij
        private int _richtingX = 0; // welke x as?

        private int _richtingY = 0; // welke y as?

        //
        // eigenschappen
        //

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public int Leeftijd
        {
            get { return _leeftijd; }
            set { _leeftijd = value; }
        }
        public double gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        public int MaagGevuld
        {
            get { return _maagGevuld; }
            set { _maagGevuld = value; }
        }
        public int voedingswaarde
        {
            get { return _voedingswaarde;}
            set { _voedingswaarde = value;}
        }
        public DateTime geboortedatum
        {
            get { return _geboortedatum;}
            set { _geboortedatum = value;}
        }
        public DateTime sterfdatum
        {
            get { return _sterfdatum; }
            set { _sterfdatum = value; }
        }

        //
        // grafische eigenschappen
        //

        public Size afmetingen
        {
            get { return _afmetingen; }
            set
            {
                _afmetingen = value;
            }
        }
        public Color Kleur
        {
            get { return _kleur; }
            set
            {
                _kleur = value;
            }
        }
        public Point Locatie
        {
            get { return _locatie; }
            set
            {
                _locatie = value;
            }
        }
        public int richtingX
        {
            get { return _richtingX;}
            set
            {
                _richtingX = value;
            }
        }
        public int richtingY 
        { 
            get { return _richtingY;}
            set
            {
                _richtingY = value;
            }
        }

        //
        //ReadOnly-eigenschappen specifiek voor konijnen
        //

        public string nederlandseNaam
        {
            get { return _nederlandseNaam;}
        }
        public string latijnseNaam
        {
            get { return _latijnseNaam;}
        }
        public double gewichtmaximaal
        {
            get { return _gewichtMaximaal; }
        }
        public int Levensduur
        {
            get { return _levensduur; }
        }
        public bool verwijderd
        {
            get { return _verwijderd;}
        }

        public List<string> wordvergitgddoor
        {
            get { return _wordtVergiftigdDoor; }
        }
        public Timer verouder
        {
            get { return _verouder; }
        }

        //
        //methoden
        //

        public void Verwijder()
        {
            _verwijderd= true;
        }
        //private methoden
        private bool honger()
        {
            return (MaagGevuld < 25);
        }
        private void eetGras (Gras voedsel)
        {
            if (wordvergitgddoor.Contains(voedsel.nederlandsenaam))
            {
                if (honger()) 
                {
                    Verwijder();
                }else if(MaagGevuld < 100)
                {
                    MaagGevuld = MaagGevuld + voedsel.voedingswaarde;

                    if (MaagGevuld > 100)
                    {
                        MaagGevuld = 100;
                    }

                    voedsel.Verwijder();
                }
            }
        }
        private void eetVenijnBoom(Venijnboom voedsel)
        {
            if (wordvergitgddoor.Contains(voedsel.nederlandsenaam))
            {
                if (honger())
                {
                    Verwijder();
                }
                else if (MaagGevuld < 100)
                {
                    MaagGevuld = MaagGevuld + voedsel.voedingswaarde;

                    if (MaagGevuld > 100)
                    {
                        MaagGevuld = 100;
                    }

                    voedsel.Verwijder();
                }
            }
        }
        public void Eet(object voedsel)
        {
            if(voedsel.GetType() == typeof(Gras))
            {
                eetGras((Gras) voedsel);
            } else if(voedsel.GetType() == typeof(Venijnboom))
            {
                eetVenijnBoom((Venijnboom) voedsel);
            }
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

        //
        //instalatsie
        //

        private void initClass(Point locatie , string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            verouder.Start();
        }

        public konijn(Point locatie, string naam, Color kleur)
        {
            initClass(locatie,naam, kleur);
        }


    }
}
