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
    public partial class ViewMouvement : Form
    {
        public ViewMouvement()
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

        private void btnArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle");
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

        private void btnNewMouvement_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewnewMouvement");
        }
    }
}
