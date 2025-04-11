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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard", FindForm());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount", FindForm());
        }


        private void btnMouvement_Click(object sender, EventArgs e)
        {
            Controller.Resetnumberofpage();
;
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement", FindForm());
        }

        private void btnNewarticle_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewnewArticle", FindForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.GetcurrentUser().Length; i++)
            {
                Controller.GetcurrentUser()[i] = "";
            }

            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
        }

        private void Viewarticle_Activated(object sender, EventArgs e)
        {
            Controller.Resetnumberofpage();
            Controller.SetarticleTable();
            Controller.AfficherPageArticle(Controller.Getnumberofpage(), FindForm(), pnlArticlebutton);

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if ((Controller.Getnumberofpage() + 1) * Controller.GetnumberofarticleBypage() < Controller.GetarticleTable().GetLength(0))
            {
                Controller.Plusnumberofpage();
                lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());
                Controller.AfficherPageArticle(Controller.Getnumberofpage(), FindForm(), pnlArticlebutton);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Controller.Getnumberofpage() > 0)
            {
                Controller.Minusnumberofpage();
                lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());
                Controller.AfficherPageArticle(Controller.Getnumberofpage(), FindForm(), pnlArticlebutton);
            }
        }
    }
}
