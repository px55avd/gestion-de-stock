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
            Controller.Resetnumberofpage();

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
            Controller.Resetnumberofpage();
            Controller.SetarticleTable();
            Controller.AfficherPageArticle(Controller.Getnumberofpage(), FindForm(), pnlArticlebutton);

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if ((Controller.Getnumberofpage() + 1) * Controller.GetnumberofarticleBypage() < Controller.TransferarticleData().GetLength(0))
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
