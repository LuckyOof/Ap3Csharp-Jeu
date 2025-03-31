using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliPendu
{
    public partial class FrmPendu : Form
    {
        public FrmPendu()
        {
            InitializeComponent();
        }
        //----------------------------------------------------
        // Phrase à trouver, nombre de coups joués et d'échecs
        //----------------------------------------------------
        string phrase;
        int coup;
        int echec;
        List<char> lettresIncorrectes;

        private void FrmPendu_Load(object sender, EventArgs e)
        {
            int i;      // Compteur
            string c;   // Caractère correspodant à la touche appuyée
            lettresIncorrectes = new List<char>();

            //-----------------
            // Démarrage du jeu
            //-----------------
            coup = 0;   // Nb. de coups
            echec = 0;  // Nb. d'échecs

            // On recherche aléatoirement une phrase parmi les 6
            // et on initialise la variable "Phrase"
            Random r = new Random();
            i = r.Next(0, 9);
            switch (i)
            {
                case 0:
                    phrase = "COMMENTER SON CODE";
                    break;
                case 1:
                    phrase = "BIENVENUE LES ETUDIANTS EN SLAM";
                    break;
                case 2:
                    phrase = "J\'AIME PROGRAMMER EN LANGAGE PYTHON!";
                    break;
                case 3:
                    phrase = "DEUX POINTS EN PLUS SI J\'APPORTE DES FRAISES TAGADA A MA PROF";
                    break;
                case 4:
                    phrase = "CINQ POINTS SI CE SONT DES PINK";
                    break;
                case 5:
                    phrase = "JE N\'OUBLIE PAS MA CLE USB EN COURS";
                    break;
                case 6:
                    phrase = "IL FAUT BIEN INDENTER SON CODE ";
                    break;
                case 7:
                    phrase = "IL FAUT PRENDRE DES DOUCHES ";
                    break;
                case 8:
                    phrase = "IL FAUT QUE JE TROUVE UN STAGE ";
                    break;
            }
            MessageBox.Show("Phrase a trouver : " + phrase, "Le Pendu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // On renseigne la zone "Phrase à deviner..."
            // Pour chaque caractère de 'Phrase', affichage d'un '#'
            // s'il est dans l'alphabet ou le caractère lui-même sinon
            for (i = 0; i <= phrase.Length - 1; i++)
            {
                // On extrait le caractère en cours
                c = phrase.Substring(i, 1);

                //---------------------------------------------------------------------
                // Pour les caractères de l'alphabet (A-Z)) on place un # dans le label
                //---------------------------------------------------------------------

                // Code ASCII du caractère
                // a. La chaîne est transformée en TABLEAU de caractères
                // b. On prend le 1er élément qui est un caractère
                // c. Le "cast" (int) donne son ode ASCII
                int code = (int)c.ToCharArray()[0];
                if (code >= 65 && code <= 90)
                    Label_Mot.Text += "#";
                else
                    // Pour les autres caractères on place le caractère lui même
                    Label_Mot.Text += c;
            }
        }

        private void FrmPendu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caractere = char.ToUpper(e.KeyChar);

            // Incrémentation du nombre de coups
            coup++;

            bool trouve = false;

            if (!lettresIncorrectes.Contains(caractere))
            {
                // Vérifier si la lettre est présente dans la phrase
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (caractere == phrase[i])
                    {
                        trouve = true;
                        Label_Mot.Text = Label_Mot.Text.Substring(0, i) + caractere + Label_Mot.Text.Substring(i + 1);
                    }
                }
                // Afficher la lettre si elle n'a pas déjà été affichée
                if (!trouve)
                {
                    echec++;
                    lettresIncorrectes.Add(caractere);
                    Label_Lettres.Text += caractere;
                }

                if (echec == 11)
                {
                    MessageBox.Show("Vous avez perdu !!! Vous êtes mort !");
                    Application.Exit();
                }
                // Vérifier si le joueur a gagné
                if (Label_Mot.Text.IndexOf('#') == -1)
                {
                    MessageBox.Show("Félicitations !!! Vous avez trouvé la phrase !!!!! ");
                    Application.Exit();
                }
                // Redessiner
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Lettre déjà essayée !");
            }
        }
    

        private void FrmPendu_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Blue, 4);
                //a chaque faute, le pendu se dessine progressivement 
                switch (echec)
                {
                    case 1:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));//support vertical
                        break;
                    case 2:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));// Dessiner la poutre horizontale supérieure
                        break;
                    case 3:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));// Dessiner la poutre horizontale inférieure
                        break;
                    case 4:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));// Dessiner la traverse
                        break;
                    case 5:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130)); // Dessiner la corde
                        break;
                    case 6:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130));
                        g.DrawEllipse(pen, 180, 130, 40, 40);// Dessiner la tête
                        break;
                    case 7:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130));
                        g.DrawEllipse(pen, 180, 130, 40, 40);
                        g.DrawLine(pen, new Point(200, 170), new Point(200, 270));// Dessiner le corps
                        break;
                    case 8:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130));
                        g.DrawEllipse(pen, 180, 130, 40, 40);
                        g.DrawLine(pen, new Point(200, 170), new Point(200, 270));
                        g.DrawLine(pen, new Point(200, 200), new Point(160, 230));// Dessiner le bras gauche
                        break;
                    case 9:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130));
                        g.DrawEllipse(pen, 180, 130, 40, 40);
                        g.DrawLine(pen, new Point(200, 170), new Point(200, 270));
                        g.DrawLine(pen, new Point(200, 200), new Point(160, 230));
                        g.DrawLine(pen, new Point(200, 200), new Point(240, 230));// Dessiner le bras gauche
                        break;
                    case 10:
                        g.DrawLine(pen, new Point(100, 350), new Point(100, 50));//support vertical
                        g.DrawLine(pen, new Point(100, 50), new Point(250, 50));// Dessiner la poutre horizontale supérieure
                        g.DrawLine(pen, new Point(250, 50), new Point(250, 100));// Dessiner la poutre horizontale inférieure
                        g.DrawLine(pen, new Point(250, 100), new Point(200, 100));// Dessiner la traverse
                        g.DrawLine(pen, new Point(200, 100), new Point(200, 130));// Dessiner la corde
                        g.DrawEllipse(pen, 180, 130, 40, 40);                     // Dessiner la tête
                        g.DrawLine(pen, new Point(200, 170), new Point(200, 270));// Dessiner le corps
                        g.DrawLine(pen, new Point(200, 200), new Point(160, 230));// Dessiner le bras gauche
                        g.DrawLine(pen, new Point(200, 200), new Point(240, 230));// Dessiner le bras gauche
                        g.DrawLine(pen, new Point(200, 270), new Point(170, 320));//dessiner la jambe droite
                        g.DrawLine(pen, new Point(200, 270), new Point(230, 320));//dessiner la jambe gauche 
                        break;
                }
            }
        }
    }
}
