using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    public class Alleseter : Dier
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
            else if (leven.IsPlant)
            {
                if (WodtVergiftigdDoor.Contains(leven.NederlandseNaam))
                {
                    if (Honger())
                    {
                        this.Sterf();
                        leven.Sterf();
                    }
                    else
                    {
                        SnelheidObject = SnelheidObject.Keerom();
                    }
                 }
                 else if (MaagGevuld < 100)
                 {
                    MaagGevuld = MaagGevuld + leven.Voedingswaarde;
                    leven.Sterf();
                 }
             }
            else
            {
                    SnelheidObject = SnelheidObject.Keerom();
            }
        }
    

        public Alleseter(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) : base(verhoudingTicksJaren, latijnseNaam, levensduur, gewichtMaximaal) { }

    }
}
