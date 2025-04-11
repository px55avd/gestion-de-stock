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
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount", FindForm());
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle", FindForm());
        }
        
        private void btnMouvement_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement", this);
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

        private void Viewdashboard_Activated(object sender, EventArgs e)
        {
            
            lblTotalstock.Text = "Total Stock : ";
            lblNumbercriticArticle.Text = "Nombre d'articles critiques : ";

            
            lblTotalstock.Text += " " + Convert.ToString(Controller.GettotalArticle());

            lblNumbercriticArticle.Text += " " + Convert.ToString(Controller.GetcriticalArticle());

            Controller.SetMouvementTable();
            Controller.AfficherPageMouvementinDashboard(FindForm(), pnlLastmouvementinDashboard);

        }

    }
}
