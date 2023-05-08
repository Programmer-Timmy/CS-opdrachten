using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatSim
{
    public partial class FrmNatSimII : Form
    {
        Graphics papier;
        public FrmNatSimII()
        {
            InitializeComponent();

            
        }

        private void FrmNatSim_Load(object sender, EventArgs e)
        {


            papier = pbWereld.CreateGraphics();

        }

        private void ResizePictureBox()
        {
            int margeBreedte = 40;
            int margeHoogte = 64;
            pbWereld.Width =
                this.Width - gbrDieren.Width - grbPlanten.Width - margeBreedte;
            pbWereld.Height = this.Height - margeHoogte;
            papier = pbWereld.CreateGraphics();
        }

        private void ResizeLblInformatie()
        {
            int margeHoogte = 88;
            lblInformatie.Height = this.Height - margeHoogte - pnlKnoppen.Height;
        }

        private void FrmNatSim_Resize(object sender, EventArgs e)
        {
            ResizePictureBox();
            ResizeLblInformatie();
        }

        private void pbWereld_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TekenDier(e.Location);
            }

            if (e.Button == MouseButtons.Right)
            {
                TekenPlant(e.Location);
            }
        }

        private void TekenDier(Point positsie)
        {
            if (rdbKonijn.Checked == true) 
            {
                konijn konijn01 = new konijn(positsie, "flappie", Color.Brown);
                konijn01.Teken(pbWereld.CreateGraphics());
            }
            else if (rdbKoe.Checked == true)
            {
                Koe koe01 = new Koe(positsie, "jan", Color.Black);
                koe01.Teken(pbWereld.CreateGraphics());
            }
        }
        private void TekenPlant(Point positsie)
        {
            if (rdbGras.Checked == true)
            {
                Gras gras01 = new Gras(positsie);
                gras01.Teken(pbWereld.CreateGraphics());
            }
            else if (rdbVeijnboom.Checked == true)
            {
                Venijnboom venijnboom01 = new Venijnboom(positsie);
                venijnboom01.Teken(pbWereld.CreateGraphics());
            }
        }
    }
}
