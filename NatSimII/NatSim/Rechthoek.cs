﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public class Rechthoek
    {
        public Rechthoek() { }
        public Rechthoek(Point locatie, Size afmetingen) 
        {
            Locatie = locatie;
            Afmetingen = afmetingen;
        }

        public Size Afmetingen { get; set; }
        public Point A { get; set; }
        public Point B { get { return new Point(A.X + Breedte, A.Y); } }
        public Point C { get { return new Point(A.X , A.Y + Hoogte); } }
        public Point D { get { return new Point(B.X , C.Y); } }

        public Point Locatie
        {
            get
            {
                return A;
            }
            set
            {
                A = value;
            }

        }

        public int Breedte
        {
            get
            {
                return Afmetingen.Width;
            }

        }

        public int Hoogte
        {
            get { return Afmetingen.Height; }
        }

        public static Vlak GrensBereikt(Rechthoek rechthoek1, Rechthoek rechthoek2)
        {
            Vlak vlak = Vlak.Geen;

            if (rechthoek1.A.X <= rechthoek2.A.X || rechthoek1.B.X >= rechthoek2.B.X)
            {
                vlak = Vlak.Verticaal;
            }
            if (rechthoek1.A.Y <= rechthoek2.A.Y || rechthoek1.C.Y >= rechthoek2.C.Y)
            {
                if (vlak == Vlak.Verticaal)
                {
                    vlak = Vlak.Hoek;
                }
                else
                {
                    vlak = Vlak.Horizontaal;
                }
            }
            return vlak;
        }

        public Vlak GrensBereikt(Rechthoek rechthoek2)
        {
            return GrensBereikt(this, rechthoek2);
        }

        public bool Overlap(Rechthoek rechthoek)
        {
            return ((rechthoek.D.X >= A.X && rechthoek.A.X <= D.X) && (rechthoek.D.Y >= A.Y && rechthoek.A.Y <= D.Y));
        }

        public Rectangle ToRectangle()
        {
            return new Rectangle(Locatie, Afmetingen);
        }

        public int Oppervlak()
        {
            return Breedte * Hoogte;
        }

        public int Omtrek()
        {
            return 2 * (Breedte + Hoogte);
        }
    }
}
