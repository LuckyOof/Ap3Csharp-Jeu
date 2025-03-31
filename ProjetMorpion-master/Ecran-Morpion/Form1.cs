using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Media;

namespace Ecran_Morpion
{
    public partial class Morpion : Form
    {
        public Morpion()
        {
            InitializeComponent();
        }
        // Pour decider le tour du joueur
        private int joueur = 1;
        //le signe du joueur
        private string signe;
        //pour compter les tours
        private int compteur = 1;
        //si = a 1 les cases ne sont pas vides 
        private int caseVideA1 = 0;
        private int caseVideA2 = 0;
        private int caseVideA3 = 0;
        private int caseVideB1 = 0;
        private int caseVideB2 = 0;
        private int caseVideB3 = 0;
        private int caseVideC1 = 0;
        private int caseVideC2 = 0;
        private int caseVideC3 = 0;
        //score des joueurs
        private int scoreJ1 = 0;
        private int scoreJ2 = 0;
        //si = a 1 joue de la musique
        private int musique = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            //fermer l'application
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {// pour qu'au lancement les labels, la musique, la grille soit fonctionnels 
            AffichTour();
            ScoreJoueur();
            Jouermusique();
            CouleurBackGround();
        }
        private void AffichTour()
        {
            // le label affichera le tour et se rafraichira 
            lblTour.Text = $"Tour du joueur n°{joueur}\nTour n°{compteur}";
            compteur++;
        }
        private void CouleurBackGround()
        {
            // La grille sera gris clair 
            btnA1.BackColor = Color.LightGray;
            btnA2.BackColor = Color.LightGray;
            btnA3.BackColor = Color.LightGray;
            btnB1.BackColor = Color.LightGray;
            btnB2.BackColor = Color.LightGray;
            btnB3.BackColor = Color.LightGray;
            btnC1.BackColor = Color.LightGray;
            btnC2.BackColor = Color.LightGray;
            btnC3.BackColor = Color.LightGray;
        }
        private void Jouermusique()
        {
            // permet de jouer une musique ou non
            SoundPlayer musiqueDeFond = new SoundPlayer("musiqueDeFond.wav");
            if (musique == 1)
            { musiqueDeFond.Play(); }
            else
                musiqueDeFond.Stop();
        }
        private void TourJoueur()
        {
            // selon le joueur le signe change 
            switch (joueur)
            {
                case 1:
                    signe = "X";
                    joueur = 2;
                    break;
                case 2:
                    signe = "O";
                    joueur = 1;
                    break;
            }
        }

        private void ScoreVictoire()
        {
            //affiche un message en disant le gagnant
            if (joueur == 1)
            {
                MessageBox.Show($"Le joueur {joueur+1} remporte la partie !");
            }
            else
                MessageBox.Show($"Le joueur {joueur-1} remporte la partie !");
            //relance une partie 
            Rejouer();
            // rajoute 1 au score du gagnant 
            if (joueur == 1)
                scoreJ2++;
            else
                scoreJ1++;
            //rafraichis le score et la grille 
            ScoreJoueur();
            CouleurBackGround();
        }
        private void ConditionsVictoire()
        {
            // selon la conditions de la victoire, le pattern est en rouge, sinon il y a un message disant qu'il y a egalite 
            if (CheckConditionsVictoire(btnA1.Text, btnA2.Text, btnA3.Text))
            {
                btnA1.BackColor = Color.Red;
                btnA2.BackColor = Color.Red;
                btnA3.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnB1.Text, btnB2.Text, btnB3.Text))
            {
                btnB1.BackColor = Color.Red;
                btnB2.BackColor = Color.Red;
                btnB3.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnC1.Text, btnC2.Text, btnC3.Text))
            {
                btnC1.BackColor = Color.Red;
                btnC2.BackColor = Color.Red;
                btnC3.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnA1.Text, btnB1.Text, btnC1.Text))
            {
                btnA1.BackColor = Color.Red;
                btnB1.BackColor = Color.Red;
                btnC1.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnA2.Text, btnB2.Text, btnC2.Text))
            {
                btnA2.BackColor = Color.Red;
                btnB2.BackColor = Color.Red;
                btnC2.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnA3.Text, btnB3.Text, btnC3.Text))
            {
                btnA3.BackColor = Color.Red;
                btnB3.BackColor = Color.Red;
                btnC3.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnA1.Text, btnB2.Text, btnC3.Text))
            {
                btnA1.BackColor = Color.Red;
                btnB2.BackColor = Color.Red;
                btnC3.BackColor = Color.Red;
                this.ScoreVictoire();
            }
            else if (CheckConditionsVictoire(btnA3.Text, btnB2.Text, btnC1.Text))
            {
                btnA3.BackColor = Color.Red;
                btnB2.BackColor = Color.Red;
                btnC1.BackColor = Color.Red;
                this.ScoreVictoire();
            }

            ConditionsEgalite();
        }

        private void ScoreJoueur()
        {
            lblScores.Text = $"Joueur 1 - Joueur 2\n        {scoreJ1} - {scoreJ2}";
            //affiche le score du joueur 
        }

        private bool CheckConditionsVictoire(string symbole1, string symbole2, string symbole3)
        {
            return !string.IsNullOrEmpty(symbole1) && symbole1 == symbole2 && symbole2 == symbole3;
            //si les symbole sont les memes et ne sont pas null/vide alors il ya une victoire
        }

        private void ConditionsEgalite()
        {
            // si toutes les cases sont pleines se sera egal a 9 donc il y a egalite 
            if (caseVideA1 + caseVideA2 + caseVideA3 + caseVideB1 + caseVideB2 + caseVideB3 + caseVideC1 + caseVideC2 + caseVideC3 == 9)
            {
                MessageBox.Show("Égalité");
                Rejouer();
            }
        }

        private void Rejouer()
        {
            // pour pouvoir rejouer toutes les variables se  reinitialisent 
            compteur = 1;
            btnA1.Text = null;
            btnA2.Text = null;
            btnA3.Text = null;
            btnB1.Text = null;
            btnB2.Text = null;
            btnB3.Text = null;
            btnC1.Text = null;
            btnC2.Text = null;
            btnC3.Text = null;
            caseVideA1 = 0;
            caseVideA2 = 0;
            caseVideA3 = 0;
            caseVideB1 = 0;
            caseVideB2 = 0;
            caseVideB3 = 0;
            caseVideC1 = 0;
            caseVideC2 = 0;
            caseVideC3 = 0;
            joueur = 1;
            AffichTour();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void btnRejouer_Click(object sender, EventArgs e)
        {
            // permet de rejouer 
            Rejouer();
        }

        private void a1_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideA1 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideA1)
            {
                case 0:
                    btnA1.Text = signe;
                    caseVideA1++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideA2 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideA2)
            {
                case 0:
                    btnA2.Text = signe;
                    caseVideA2++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void a3_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideA3 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideA3)
            {
                case 0:
                    btnA3.Text = signe;
                    caseVideA3++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideB1 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideB1)
            {
                case 0:
                    btnB1.Text = signe;
                    caseVideB1++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideB2 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideB2)
            {
                case 0:
                    btnB2.Text = signe;
                    caseVideB2++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideB3 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideB3)
            {
                case 0:
                    btnB3.Text = signe;
                    caseVideB3++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideC1 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideC1)
            {
                case 0:
                    btnC1.Text = signe;
                    caseVideC1++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideC2 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideC2)
            {
                case 0:
                    btnC2.Text = signe;
                    caseVideC2++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            // si la case n'est pas vide elle est egal a 0, sinon un message d'erreur s'affiche 
            if (caseVideC3 == 0)
            { TourJoueur(); }// le tour s'actualise 

            switch (caseVideC3)
            {
                case 0:
                    btnC3.Text = signe;
                    caseVideC3++;
                    AffichTour();
                    break;
                case 1:
                    MessageBox.Show("Case déjà utilisé!!!", "ERREUR");
                    break;
            }

            ConditionsVictoire();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //joue de la musique 
            musique = 1;
            Jouermusique();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            //arrete la musique 
            musique = 0;
            Jouermusique();
        }
    }
}