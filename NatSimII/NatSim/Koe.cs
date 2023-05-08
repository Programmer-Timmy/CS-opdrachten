using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace NatSim
{
    public class Koe
    {

        //
        //eigenschappen
        //

        public string Naam { get; set; }
        public int aantallietsermelk { get; set; }
        public DateTime geboortedatum { get; set; }
        public double gewicht { get; set; }
        public int leeftijd { get; set; }
        public int maaggevult { get; set; }
        public DateTime sterfdatum { get; set; }

        public Color Kleur { get; set; }
        public Point Locatie { get; set; }
        public int richtingX { get; set; }
        public int richtingY { get; set; }


        //
        //readonly
        //

        private Size _afmetingen = new Size(80, 40);
        private double _gewichtmaximaal = 450;
        private List<string> _wordtvergiftigddoor = new List<string>() {"Venijnboom","vingerhoedskruid"};

        private string _latijnseNaam = "Bos Taurus";
        private int _levensduur = 25;
        private string _nederlandseNaam = "koe";
        private Timer _verouder = new Timer();
        private bool _verwijderd = false;

        public Size afmetingen { get {return _afmetingen;} }
        public double gewichtmaximaal { get { return _gewichtmaximaal;} }
        public List<string> wordtvergiftigddoor { get { return _wordtvergiftigddoor; } }
        public string latijnsenaam { get { return _latijnseNaam;} }
        public int levensduur { get { return _levensduur; } }
        public string nederlandseNaam { get { return _nederlandseNaam; } }
        public Timer verouder { get { return _verouder; } }
        public bool verwijderd { get { return _verwijderd; } }

        public void Verwijder()
        {
            _verwijderd = true;
        }
        private bool honger()
        {
            return (maaggevult < 25);
        }
        private void eetGras(Gras voedsel)
        {
            if (wordtvergiftigddoor.Contains(voedsel.nederlandsenaam))
            {
                if (honger())
                {
                    Verwijder();
                }
                else if (maaggevult < 100)
                {
                    maaggevult = maaggevult + voedsel.voedingswaarde;

                    if (maaggevult > 100)
                    {
                        maaggevult = 100;
                    }

                    voedsel.Verwijder();
                }
            }
        }
        private void eetVenijnBoom(Venijnboom voedsel)
        {
            if (wordtvergiftigddoor.Contains(voedsel.nederlandsenaam))
            {
                if (honger())
                {
                    Verwijder();
                }
                else if (maaggevult < 100)
                {
                    maaggevult = maaggevult + voedsel.voedingswaarde;

                    if (maaggevult > 100)
                    {
                        maaggevult = 100;
                    }

                    voedsel.Verwijder();
                }
            }
        }
        public void Eet(object voedsel)
        {
            if (voedsel.GetType() == typeof(Gras))
            {
                eetGras((Gras)voedsel);
            }
            else if (voedsel.GetType() == typeof(Venijnboom))
            {
                eetVenijnBoom((Venijnboom)voedsel);
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
        private void initClass(Point locatie, string naam, Color kleur)
        {
            Locatie = locatie;
            Naam = naam;
            Kleur = kleur;
            verouder.Start();
        }

        public Koe(Point locatie, string naam, Color kleur)
        {
            initClass(locatie, naam, kleur);
        }


    }
}
