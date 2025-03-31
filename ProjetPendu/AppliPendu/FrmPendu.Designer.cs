namespace AppliPendu
{
    partial class FrmPendu
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
            this.GrpbLettreAbs = new System.Windows.Forms.GroupBox();
            this.Label_Lettres = new System.Windows.Forms.Label();
            this.GrpbPhrGuess = new System.Windows.Forms.GroupBox();
            this.Label_Mot = new System.Windows.Forms.Label();
            this.GrpbLettreAbs.SuspendLayout();
            this.GrpbPhrGuess.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpbLettreAbs
            // 
            this.GrpbLettreAbs.Controls.Add(this.Label_Lettres);
            this.GrpbLettreAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpbLettreAbs.ForeColor = System.Drawing.Color.Blue;
            this.GrpbLettreAbs.Location = new System.Drawing.Point(365, 222);
            this.GrpbLettreAbs.Name = "GrpbLettreAbs";
            this.GrpbLettreAbs.Size = new System.Drawing.Size(482, 66);
            this.GrpbLettreAbs.TabIndex = 11;
            this.GrpbLettreAbs.TabStop = false;
            this.GrpbLettreAbs.Text = "Lettes absentes de la phrase";
            // 
            // Label_Lettres
            // 
            this.Label_Lettres.AutoSize = true;
            this.Label_Lettres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Lettres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Lettres.Location = new System.Drawing.Point(31, 28);
            this.Label_Lettres.Name = "Label_Lettres";
            this.Label_Lettres.Size = new System.Drawing.Size(0, 15);
            this.Label_Lettres.TabIndex = 0;
            // 
            // GrpbPhrGuess
            // 
            this.GrpbPhrGuess.Controls.Add(this.Label_Mot);
            this.GrpbPhrGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpbPhrGuess.ForeColor = System.Drawing.Color.Red;
            this.GrpbPhrGuess.Location = new System.Drawing.Point(365, 47);
            this.GrpbPhrGuess.Name = "GrpbPhrGuess";
            this.GrpbPhrGuess.Size = new System.Drawing.Size(482, 66);
            this.GrpbPhrGuess.TabIndex = 10;
            this.GrpbPhrGuess.TabStop = false;
            this.GrpbPhrGuess.Text = "Phrase à deviner";
            // 
            // Label_Mot
            // 
            this.Label_Mot.AutoSize = true;
            this.Label_Mot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Mot.Location = new System.Drawing.Point(31, 28);
            this.Label_Mot.Name = "Label_Mot";
            this.Label_Mot.Size = new System.Drawing.Size(0, 15);
            this.Label_Mot.TabIndex = 0;
            // 
            // FrmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 347);
            this.Controls.Add(this.GrpbLettreAbs);
            this.Controls.Add(this.GrpbPhrGuess);
            this.Location = new System.Drawing.Point(4, 23);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPendu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.FrmPendu_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPendu_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmPendu_KeyPress);
            this.GrpbLettreAbs.ResumeLayout(false);
            this.GrpbLettreAbs.PerformLayout();
            this.GrpbPhrGuess.ResumeLayout(false);
            this.GrpbPhrGuess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GrpbLettreAbs;
        internal System.Windows.Forms.Label Label_Lettres;
        internal System.Windows.Forms.GroupBox GrpbPhrGuess;
        internal System.Windows.Forms.Label Label_Mot;
    }
}

