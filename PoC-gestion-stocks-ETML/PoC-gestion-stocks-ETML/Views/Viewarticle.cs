using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoC_gestion_stocks_ETML.Views
{
    public partial class Viewarticle : Form
    {
        public Viewarticle()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        // Variables globales pour la pagination
        private int _pageActuelle = 0;
        private const int _articlesParPage = 10; // Nombre total d’articles par page
        private const int _colonnes = 2; // Nombre de colonnes
        private const int _espaceX = 210, espaceY = 50; // Espacement des boutons
        private string[,] _articles; // Stocke les articles

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount");
        }


        private void btnMouvement_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement");
        }

        private void btnNewarticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewnewArticle");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.SetcurrentUser().Length; i++)
            {
                Controller.SetcurrentUser()[i] = "";
            }


            // Afficher la vue du compte utilisateur
            Controller.changeView("View");
            this.Hide();
        }

        private void Viewarticle_Activated(object sender, EventArgs e)
        {
            _articles = Controller.TransferarticleData();
            AfficherPage(_pageActuelle);

        }


        private void AfficherPage(int page)
        {
            pnlArticlebutton.Controls.Clear(); // Efface les anciens boutons

            int nbArticles = _articles.GetLength(0);
            int debut = page * _articlesParPage;
            int fin = Math.Min(debut + _articlesParPage, nbArticles);

            for (int i = debut; i < fin; i++)
            {
                string articleName = _articles[i, 1]; // Nom de l'article

                Button btn = new Button();
                btn.Text = articleName;
                btn.Size = new Size(200, 40);

                int colonne = (i - debut) % _colonnes;
                int ligne = (i - debut) / _colonnes;

                btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                // Événement du bouton pour récupérer les infos de l'article
                int index = i; // Sauvegarde l'index pour récupérer l'article
                btn.Click += (s, args) => Controller.Getcurrentarticle(_articles[index, 0], _articles[index, 1], _articles[index, 2], _articles[index, 3], _articles[index, 4], _articles[index, 5]);
                btn.Click += (s, args) => Controller.changeView("ViewoneArticle");
                

                pnlArticlebutton.Controls.Add(btn);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if ((_pageActuelle + 1) * _articlesParPage < _articles.GetLength(0))
            {
                _pageActuelle++;
                lblNumberpages.Text = Convert.ToString(_pageActuelle);
                AfficherPage(_pageActuelle);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_pageActuelle > 0)
            {
                _pageActuelle--;
                lblNumberpages.Text = Convert.ToString(_pageActuelle);
                AfficherPage(_pageActuelle);
            }
        }


    }
}
