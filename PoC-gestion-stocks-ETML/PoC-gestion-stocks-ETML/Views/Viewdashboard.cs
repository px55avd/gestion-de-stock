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
    public partial class Viewdashboard : Form
    {
        public Viewdashboard()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount");
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle");
        }
        
        private void btnMouvement_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement");
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

        private void Viewdashboard_Activated(object sender, EventArgs e)
        {
            
            lblTotalstock.Text = "Total Stock : ";
            lblNumbercriticArticle.Text = "Nombre d'articles critiques : ";
            


            int totalArticle = 0;
            int articleCritical = 3;
            int articleTotal = 0;

            for (int i = 0; i < Controller.TransferarticleData().GetLength(0); i++)
            {
                totalArticle += Convert.ToInt32(Controller.TransferarticleData()[i, 3]);

                articleTotal = Convert.ToInt32(Controller.TransferarticleData()[i, 3]);

                if (articleTotal < articleCritical)
                {
                    articleTotal++;
                }
            }

            lblTotalstock.Text += " " + Convert.ToString(totalArticle);

            lblNumbercriticArticle.Text += " " + Convert.ToString(articleTotal);

            Controller.SetMouvementTable();
            Controller.AfficherPageMouvementinDashboard(FindForm(), pnlLastmouvementinDashboard);

        }

    }
}
