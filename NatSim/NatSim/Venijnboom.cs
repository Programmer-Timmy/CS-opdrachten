using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;

namespace NatSim
{
    public class Venijnboom
    {
        public double aantalkubiekemetershout { get; set; }
        public int leeftijd { get; set; }
        public Point Locatie { get; set; }

        private Size _afmetingen = new Size(10, 400);
        private Bloeiwijze _bloeiwijzeplant = Bloeiwijze.kegel;
        private List<string> _geneesmidelvoor = new List<string>() {"longkanker","borstkanker"};
        private Color _kleur = Color.ForestGreen;
        private string _latijnsenaam = "taxus bacatta";
        private int _levensduur = 2200;
        private int _maximalegrote = 20000;
        private string _nederlandsenaam = "venijnboom";
        private Timer _verouder = new Timer(1000);
        private bool _verwijderd = false;
        private int _voedingswaarde = 0;

        public Size afmetingen { get { return _afmetingen; } }
        public Bloeiwijze bloeiwijzeplant { get { return _bloeiwijzeplant;} }
        public List<string> geneesmidelvoor { get { return _geneesmidelvoor;} }
        public Color Kleur { get { return _kleur; } }
        public string latijnsenaam { get { return _latijnsenaam;} }
        public int levensduur { get { return _levensduur;} }
        public int maximalegrote { get { return _maximalegrote; } }
        public string nederlandsenaam { get { return _nederlandsenaam;} }
        public Timer verouder { get { return _verouder; } }
        public bool verwijderd { get { return _verwijderd; } }
        public int voedingswaarde {get { return _voedingswaarde; } }

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

        public Venijnboom(Point locatie)
        {
            initClass(locatie);
        }
    }
}
