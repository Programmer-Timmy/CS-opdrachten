using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NatSim
{
    public abstract class GrafischObject
    {
        public GrafischObject()
        {
            initClass();
        }
        public Color kleur { get; set;}
        public Color KaderKleur { get; set;}
        public Point Locatie
        {
            get { return Tekengebied.Locatie; }
            set { Tekengebied.Locatie = value; }
        }

        public Graphics Papier
        {
            get { return _papier; }
            set
            {
                _papier = value;

                if (value != null)
                {
                    int breedteVenster = (int)Papier.VisibleClipBounds.Width;
                    int hoogteVenster = (int)Papier.VisibleClipBounds.Height;
                    _graphicsVenster = new Rechthoek(new Point(0,0), new Size(breedteVenster, hoogteVenster));
                }
            }
        }
        public Rechthoek Tekengebied { get; set; }
        public Color Wiskleur { get; set; }
        public Rechthoek graphicsVenster { get { return _graphicsVenster; } }
        public Guid ID { get { return _id; } }

        private Guid _id;
        private bool _verwijderd = false;
        private Graphics _papier;
        private Rechthoek _graphicsVenster;

        private void initClass()
        {
            KaderKleur = Color.Black;
            kleur = Color.WhiteSmoke;
            Wiskleur = Color.PaleGoldenrod;

            Tekengebied = new Rechthoek();

            _id = Guid.NewGuid();
        }

        public void Verwijder()
        {
            _verwijderd = true;
            Wis();
        }
        public void Wis()
        {
            Color oudeKleur = kleur;
            Color oudeKaderKleur = KaderKleur;
            kleur = Wiskleur;
            KaderKleur = Wiskleur;
            Teken();
            KaderKleur = oudeKaderKleur;
            kleur = oudeKleur;
        }
        public void Teken(Graphics papier)
        {
            Papier = papier;

            Pen pen = new Pen(KaderKleur, 2);

            if (Papier != null)
            {
                papier.DrawRectangle(pen, Tekengebied.ToRectangle());
            }
            pen.Dispose();

            SolidBrush kwast = new SolidBrush(kleur);
            Papier.FillRectangle(kwast, Tekengebied.ToRectangle());

            kwast.Dispose();
        }
        public void Teken()
        {
            Teken(Papier);
        }
    }
    
}
