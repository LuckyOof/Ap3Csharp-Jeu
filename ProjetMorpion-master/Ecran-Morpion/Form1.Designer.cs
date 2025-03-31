namespace Ecran_Morpion
{
    partial class Morpion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblScores = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.grpbMorpion = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.pctbBarre4 = new System.Windows.Forms.PictureBox();
            this.pctbBarre2 = new System.Windows.Forms.PictureBox();
            this.pctbBarre1 = new System.Windows.Forms.PictureBox();
            this.pctbBarre3 = new System.Windows.Forms.PictureBox();
            this.grpbMorpion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.MediumPurple;
            this.btnQuitter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic);
            this.btnQuitter.Location = new System.Drawing.Point(4, 271);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(249, 53);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRejouer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejouer.Location = new System.Drawing.Point(4, 148);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(249, 58);
            this.btnRejouer.TabIndex = 4;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // lblTour
            // 
            this.lblTour.BackColor = System.Drawing.Color.MediumPurple;
            this.lblTour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblTour.Location = new System.Drawing.Point(291, 9);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(293, 68);
            this.lblTour.TabIndex = 5;
            this.lblTour.Text = "Tours";
            // 
            // lblScores
            // 
            this.lblScores.BackColor = System.Drawing.Color.MediumPurple;
            this.lblScores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblScores.Location = new System.Drawing.Point(12, 9);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(277, 68);
            this.lblScores.TabIndex = 6;
            this.lblScores.Text = "Scores";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnC2
            // 
            this.btnC2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC2.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnC2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnC2.Location = new System.Drawing.Point(112, 191);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(100, 80);
            this.btnC2.TabIndex = 17;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.c2_Click);
            // 
            // btnA1
            // 
            this.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA1.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnA1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnA1.Location = new System.Drawing.Point(6, 19);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(100, 80);
            this.btnA1.TabIndex = 16;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.a1_Click);
            // 
            // btnC3
            // 
            this.btnC3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC3.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnC3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnC3.Location = new System.Drawing.Point(218, 191);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(100, 80);
            this.btnC3.TabIndex = 15;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.c3_Click);
            // 
            // btnC1
            // 
            this.btnC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC1.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnC1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnC1.Location = new System.Drawing.Point(6, 191);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(100, 80);
            this.btnC1.TabIndex = 13;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.c1_Click);
            // 
            // btnB3
            // 
            this.btnB3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnB3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB3.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnB3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnB3.Location = new System.Drawing.Point(218, 105);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(100, 80);
            this.btnB3.TabIndex = 12;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.b3_Click);
            // 
            // btnB2
            // 
            this.btnB2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB2.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnB2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnB2.Location = new System.Drawing.Point(112, 105);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(100, 80);
            this.btnB2.TabIndex = 11;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.b2_Click);
            // 
            // btnB1
            // 
            this.btnB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB1.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnB1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnB1.Location = new System.Drawing.Point(6, 105);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(100, 80);
            this.btnB1.TabIndex = 10;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.b1_Click);
            // 
            // btnA3
            // 
            this.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA3.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnA3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnA3.Location = new System.Drawing.Point(218, 19);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(100, 80);
            this.btnA3.TabIndex = 9;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.a3_Click);
            // 
            // btnA2
            // 
            this.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA2.Font = new System.Drawing.Font("Tempus Sans ITC", 50.25F, System.Drawing.FontStyle.Bold);
            this.btnA2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnA2.Location = new System.Drawing.Point(112, 19);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(100, 80);
            this.btnA2.TabIndex = 8;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.a2_Click);
            // 
            // grpbMorpion
            // 
            this.grpbMorpion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpbMorpion.Controls.Add(this.btnA1);
            this.grpbMorpion.Controls.Add(this.btnC2);
            this.grpbMorpion.Controls.Add(this.btnB2);
            this.grpbMorpion.Controls.Add(this.btnC3);
            this.grpbMorpion.Controls.Add(this.btnB1);
            this.grpbMorpion.Controls.Add(this.btnA2);
            this.grpbMorpion.Controls.Add(this.btnB3);
            this.grpbMorpion.Controls.Add(this.btnC1);
            this.grpbMorpion.Controls.Add(this.btnA3);
            this.grpbMorpion.Controls.Add(this.pctbBarre4);
            this.grpbMorpion.Controls.Add(this.pctbBarre2);
            this.grpbMorpion.Controls.Add(this.pctbBarre1);
            this.grpbMorpion.Controls.Add(this.pctbBarre3);
            this.grpbMorpion.Location = new System.Drawing.Point(259, 139);
            this.grpbMorpion.Name = "grpbMorpion";
            this.grpbMorpion.Size = new System.Drawing.Size(325, 281);
            this.grpbMorpion.TabIndex = 24;
            this.grpbMorpion.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPlay.BackgroundImage = global::Ecran_Morpion.Properties.Resources._309542;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(18, 349);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(86, 73);
            this.btnPlay.TabIndex = 26;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMute.BackgroundImage = global::Ecran_Morpion.Properties.Resources.speaker_mute_filled_icon_199700;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMute.Location = new System.Drawing.Point(141, 349);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(86, 73);
            this.btnMute.TabIndex = 25;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // pctbBarre4
            // 
            this.pctbBarre4.Image = global::Ecran_Morpion.Properties.Resources.fond_noir;
            this.pctbBarre4.Location = new System.Drawing.Point(6, 175);
            this.pctbBarre4.Name = "pctbBarre4";
            this.pctbBarre4.Size = new System.Drawing.Size(312, 21);
            this.pctbBarre4.TabIndex = 23;
            this.pctbBarre4.TabStop = false;
            // 
            // pctbBarre2
            // 
            this.pctbBarre2.Image = global::Ecran_Morpion.Properties.Resources.fond_noir;
            this.pctbBarre2.Location = new System.Drawing.Point(207, 19);
            this.pctbBarre2.Name = "pctbBarre2";
            this.pctbBarre2.Size = new System.Drawing.Size(17, 252);
            this.pctbBarre2.TabIndex = 22;
            this.pctbBarre2.TabStop = false;
            // 
            // pctbBarre1
            // 
            this.pctbBarre1.Image = global::Ecran_Morpion.Properties.Resources.fond_noir;
            this.pctbBarre1.Location = new System.Drawing.Point(101, 19);
            this.pctbBarre1.Name = "pctbBarre1";
            this.pctbBarre1.Size = new System.Drawing.Size(18, 252);
            this.pctbBarre1.TabIndex = 21;
            this.pctbBarre1.TabStop = false;
            // 
            // pctbBarre3
            // 
            this.pctbBarre3.Image = global::Ecran_Morpion.Properties.Resources.fond_noir;
            this.pctbBarre3.Location = new System.Drawing.Point(6, 89);
            this.pctbBarre3.Name = "pctbBarre3";
            this.pctbBarre3.Size = new System.Drawing.Size(312, 21);
            this.pctbBarre3.TabIndex = 18;
            this.pctbBarre3.TabStop = false;
            // 
            // Morpion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 449);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.grpbMorpion);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Morpion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbMorpion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbBarre3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblScores;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.PictureBox pctbBarre3;
        private System.Windows.Forms.PictureBox pctbBarre1;
        private System.Windows.Forms.PictureBox pctbBarre2;
        private System.Windows.Forms.PictureBox pctbBarre4;
        private System.Windows.Forms.GroupBox grpbMorpion;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnA1;
    }
}

