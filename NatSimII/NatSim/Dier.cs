using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    public abstract class Dier : Leven
    {
        public Dier(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) : base(verhoudingTicksJaren, latijnseNaam, levensduur)
        {
            initDier(gewichtMaximaal);
        }

        private void initDier(double gewichtMaximaal)
        {
            _gewichtMaximaal = gewichtMaximaal;
            WodtVergiftigdDoor = new List<string>();
        }

        private double _gewichtMaximaal = 0;

        public int MaagGevuld { get; set; }
        public int SpijsverteringsDuur { get; set; }
        public double GewichtMaximaal { get { return _gewichtMaximaal; } }
        public List<string> WodtVergiftigdDoor { get; set; }
        public Snelheid SnelheidObject { get; set; }

        public abstract void Eet(Leven leven);

        public bool Honger()
        {
            return (MaagGevuld < 25);
        }
    }
}
