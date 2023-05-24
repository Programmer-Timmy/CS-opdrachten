using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatSim
{
    abstract class Planteneter : Dier
    {
        public override void Eet(Leven leven)
        {
            if (leven.IsPlant)
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

        public Planteneter(int verhoudingTicksJaren, string latijnseNaam, int levensduur, double gewichtMaximaal) : base(verhoudingTicksJaren, latijnseNaam, levensduur, gewichtMaximaal) { }

    }
}
