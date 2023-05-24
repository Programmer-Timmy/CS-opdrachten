using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    internal class konijn : Planteneter
    {
       public konijn() :base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd,_gewichtMaximaal)
        {
            initClass(new Point(0,0), "", Color.Black);
        }
        public konijn(Point locatie) :base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal)
        {
            initClass(locatie, "",Color.Black);
        }
        public konijn(Point locatie, string naam, Color kleur) : base(_verhoudingTicksJaren, _latijnseNaam, _leeftijd, _gewichtMaximaal)
        {
            initClass(locatie, naam , kleur);
        }

        private void initClass(Point locatie, string naam , Color kleur)
        {
            Locatie= locatie;
            Naam = naam;
            Kleur = kleur;
            Tekengebied.Afmetingen = new Size(10,10);
            WodtVergiftigdDoor.Add("Vingerhoedskruid");
            WodtVergiftigdDoor.Add("Venijnbom");
            Gewicht = 5;
            Voedingswaarde = 1;
        }

        private const string _latijnseNaam = "Oryctolagus cuniculus";
        private const int _leeftijd = 9;
        private const int _verhoudingTicksJaren = 1;
        private const double _gewichtMaximaal = 10;

        public string Naam { get; set; }
        public double Gewicht { get; set; }
        public DateTime Geboortedatum { get; set; }
        public DateTime Sterfdatum { get; set; }
        public Color Kleur { get; set; }

    }
}
