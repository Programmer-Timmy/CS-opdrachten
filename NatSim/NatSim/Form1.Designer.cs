namespace NatSim
{
    partial class FrmNatSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbrDieren = new System.Windows.Forms.GroupBox();
            this.rdbKonijn = new System.Windows.Forms.RadioButton();
            this.rdbKoe = new System.Windows.Forms.RadioButton();
            this.rdbLynx = new System.Windows.Forms.RadioButton();
            this.rdbBeer = new System.Windows.Forms.RadioButton();
            this.grbPlanten = new System.Windows.Forms.GroupBox();
            this.rdbGras = new System.Windows.Forms.RadioButton();
            this.rdbVeijnboom = new System.Windows.Forms.RadioButton();
            this.rdbVingerhoedskruid = new System.Windows.Forms.RadioButton();
            this.rdbZaai = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInformatie = new System.Windows.Forms.Label();
            this.pbWereld = new System.Windows.Forms.PictureBox();
            this.pnlKnoppen = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnEinde = new System.Windows.Forms.Button();
            this.gbrDieren.SuspendLayout();
            this.grbPlanten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).BeginInit();
            this.pnlKnoppen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrDieren
            // 
            this.gbrDieren.BackColor = System.Drawing.Color.BurlyWood;
            this.gbrDieren.Controls.Add(this.rdbBeer);
            this.gbrDieren.Controls.Add(this.rdbLynx);
            this.gbrDieren.Controls.Add(this.rdbKoe);
            this.gbrDieren.Controls.Add(this.rdbKonijn);
            this.gbrDieren.Location = new System.Drawing.Point(12, 12);
            this.gbrDieren.Name = "gbrDieren";
            this.gbrDieren.Size = new System.Drawing.Size(119, 192);
            this.gbrDieren.TabIndex = 0;
            this.gbrDieren.TabStop = false;
            this.gbrDieren.Text = "dier";
            // 
            // rdbKonijn
            // 
            this.rdbKonijn.AutoSize = true;
            this.rdbKonijn.Checked = true;
            this.rdbKonijn.Location = new System.Drawing.Point(6, 19);
            this.rdbKonijn.Name = "rdbKonijn";
            this.rdbKonijn.Size = new System.Drawing.Size(54, 17);
            this.rdbKonijn.TabIndex = 1;
            this.rdbKonijn.TabStop = true;
            this.rdbKonijn.Text = "Konijn";
            this.rdbKonijn.UseVisualStyleBackColor = true;
            // 
            // rdbKoe
            // 
            this.rdbKoe.AutoSize = true;
            this.rdbKoe.Location = new System.Drawing.Point(6, 42);
            this.rdbKoe.Name = "rdbKoe";
            this.rdbKoe.Size = new System.Drawing.Size(44, 17);
            this.rdbKoe.TabIndex = 2;
            this.rdbKoe.Text = "Koe";
            this.rdbKoe.UseVisualStyleBackColor = true;
            // 
            // rdbLynx
            // 
            this.rdbLynx.AutoSize = true;
            this.rdbLynx.Location = new System.Drawing.Point(6, 65);
            this.rdbLynx.Name = "rdbLynx";
            this.rdbLynx.Size = new System.Drawing.Size(47, 17);
            this.rdbLynx.TabIndex = 3;
            this.rdbLynx.Text = "Lynx";
            this.rdbLynx.UseVisualStyleBackColor = true;
            // 
            // rdbBeer
            // 
            this.rdbBeer.AutoSize = true;
            this.rdbBeer.Location = new System.Drawing.Point(6, 88);
            this.rdbBeer.Name = "rdbBeer";
            this.rdbBeer.Size = new System.Drawing.Size(47, 17);
            this.rdbBeer.TabIndex = 4;
            this.rdbBeer.Text = "Beer";
            this.rdbBeer.UseVisualStyleBackColor = true;
            // 
            // grbPlanten
            // 
            this.grbPlanten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbPlanten.BackColor = System.Drawing.Color.PaleGreen;
            this.grbPlanten.Controls.Add(this.rdbZaai);
            this.grbPlanten.Controls.Add(this.rdbVingerhoedskruid);
            this.grbPlanten.Controls.Add(this.rdbVeijnboom);
            this.grbPlanten.Controls.Add(this.rdbGras);
            this.grbPlanten.Location = new System.Drawing.Point(12, 210);
            this.grbPlanten.Name = "grbPlanten";
            this.grbPlanten.Size = new System.Drawing.Size(119, 169);
            this.grbPlanten.TabIndex = 1;
            this.grbPlanten.TabStop = false;
            this.grbPlanten.Text = "planten";
            // 
            // rdbGras
            // 
            this.rdbGras.AutoSize = true;
            this.rdbGras.Checked = true;
            this.rdbGras.Location = new System.Drawing.Point(7, 20);
            this.rdbGras.Name = "rdbGras";
            this.rdbGras.Size = new System.Drawing.Size(47, 17);
            this.rdbGras.TabIndex = 5;
            this.rdbGras.TabStop = true;
            this.rdbGras.Text = "Gras";
            this.rdbGras.UseVisualStyleBackColor = true;
            // 
            // rdbVeijnboom
            // 
            this.rdbVeijnboom.AutoSize = true;
            this.rdbVeijnboom.Location = new System.Drawing.Point(6, 42);
            this.rdbVeijnboom.Name = "rdbVeijnboom";
            this.rdbVeijnboom.Size = new System.Drawing.Size(74, 17);
            this.rdbVeijnboom.TabIndex = 6;
            this.rdbVeijnboom.Text = "Veijnboom";
            this.rdbVeijnboom.UseVisualStyleBackColor = true;
            // 
            // rdbVingerhoedskruid
            // 
            this.rdbVingerhoedskruid.AutoSize = true;
            this.rdbVingerhoedskruid.Location = new System.Drawing.Point(6, 65);
            this.rdbVingerhoedskruid.Name = "rdbVingerhoedskruid";
            this.rdbVingerhoedskruid.Size = new System.Drawing.Size(107, 17);
            this.rdbVingerhoedskruid.TabIndex = 8;
            this.rdbVingerhoedskruid.Text = "Vingerhoedskruid";
            this.rdbVingerhoedskruid.UseVisualStyleBackColor = true;
            // 
            // rdbZaai
            // 
            this.rdbZaai.AutoSize = true;
            this.rdbZaai.Location = new System.Drawing.Point(62, 20);
            this.rdbZaai.Name = "rdbZaai";
            this.rdbZaai.Size = new System.Drawing.Size(46, 17);
            this.rdbZaai.TabIndex = 6;
            this.rdbZaai.Text = "Zaai";
            this.rdbZaai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Natuurinfo";
            // 
            // lblInformatie
            // 
            this.lblInformatie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformatie.BackColor = System.Drawing.Color.Khaki;
            this.lblInformatie.Location = new System.Drawing.Point(483, 31);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(103, 173);
            this.lblInformatie.TabIndex = 0;
            // 
            // pbWereld
            // 
            this.pbWereld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbWereld.Location = new System.Drawing.Point(137, 12);
            this.pbWereld.Name = "pbWereld";
            this.pbWereld.Size = new System.Drawing.Size(340, 367);
            this.pbWereld.TabIndex = 2;
            this.pbWereld.TabStop = false;
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKnoppen.Controls.Add(this.btnEinde);
            this.pnlKnoppen.Controls.Add(this.hScrollBar1);
            this.pnlKnoppen.Controls.Add(this.label2);
            this.pnlKnoppen.Location = new System.Drawing.Point(486, 210);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(100, 169);
            this.pnlKnoppen.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Snelheid";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(22, 130);
            this.hScrollBar1.Minimum = 1;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(75, 10);
            this.hScrollBar1.TabIndex = 9;
            this.hScrollBar1.Value = 1;
            // 
            // btnEinde
            // 
            this.btnEinde.AllowDrop = true;
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(22, 143);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 10;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            // 
            // FrmNatSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this.pnlKnoppen);
            this.Controls.Add(this.pbWereld);
            this.Controls.Add(this.lblInformatie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbPlanten);
            this.Controls.Add(this.gbrDieren);
            this.Name = "FrmNatSim";
            this.Text = "Natuursimulatie";
            this.Load += new System.EventHandler(this.FrmNatSim_Load);
            this.Resize += new System.EventHandler(this.FrmNatSim_Resize);
            this.gbrDieren.ResumeLayout(false);
            this.gbrDieren.PerformLayout();
            this.grbPlanten.ResumeLayout(false);
            this.grbPlanten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWereld)).EndInit();
            this.pnlKnoppen.ResumeLayout(false);
            this.pnlKnoppen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrDieren;
        private System.Windows.Forms.RadioButton rdbBeer;
        private System.Windows.Forms.RadioButton rdbLynx;
        private System.Windows.Forms.RadioButton rdbKoe;
        private System.Windows.Forms.RadioButton rdbKonijn;
        private System.Windows.Forms.GroupBox grbPlanten;
        private System.Windows.Forms.RadioButton rdbZaai;
        private System.Windows.Forms.RadioButton rdbVingerhoedskruid;
        private System.Windows.Forms.RadioButton rdbVeijnboom;
        private System.Windows.Forms.RadioButton rdbGras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInformatie;
        private System.Windows.Forms.PictureBox pbWereld;
        private System.Windows.Forms.Panel pnlKnoppen;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
    }
}

