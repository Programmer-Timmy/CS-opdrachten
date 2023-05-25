using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    public abstract class Vleeseter : Dier
    {
        public override void Eet(Leven leven)
        {
            if (leven is Dier dier && dier.GewichtMaximaal < this.GewichtMaximaal)
            {
                if (MaagGevuld < 100)
                {
                    leven.Sterf();
                    MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                }
            }
            else
            {
                SnelheidObject = SnelheidObject.Keerom();
            }
        }

        public Vleeseter(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) : base(verhoudingTicksJaren, latijnseNaam, levensduur, gewichtMaximaal) { }

    }
}
