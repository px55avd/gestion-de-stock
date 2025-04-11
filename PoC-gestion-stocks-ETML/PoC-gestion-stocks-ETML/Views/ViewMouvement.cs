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
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard",FindForm());
        }

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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.GetcurrentUser().Length; i++)
            {
                Controller.GetcurrentUser()[i] = "";
            }

            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
        }

        private void btnNewMouvement_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewnewMouvement", FindForm());
        }

        private void btnMibus_Click(object sender, EventArgs e)
        {
            if (Controller.Getnumberofpage() > 0)
            {
                Controller.Minusnumberofpage();
                lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());
                Controller.AfficherPageMouvement(Controller.Getnumberofpage(), FindForm(), pnlMouvementbutton);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if ((Controller.Getnumberofpage() + 1) * Controller.GetnumberofmouvementBypage() < Controller.GetMouvementTable().GetLength(0))
            {
                Controller.Plusnumberofpage();
                lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());
                Controller.AfficherPageMouvement(Controller.Getnumberofpage(), FindForm(), pnlMouvementbutton);
            }
        }

        private void ViewMouvement_Activated(object sender, EventArgs e)
        {
            Controller.Resetnumberofpage();

            lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());

            Controller.SetMouvementTable();

            Controller.AfficherPageMouvement(Controller.Getnumberofpage(), FindForm(), pnlMouvementbutton);

            cmboxCategory.Items.Clear();

            cmboxCategory.Text = "Toutes Catégories";

            txtboxSearch.Text = "Zone de recherche...";

            for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
            {
                cmboxCategory.Items.Add(Controller.TransfercategoryData()[i, 1]);
            }

            cmboxCategory.Items.Add("Toutes Catégories");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtboxSearch.Text != "Zone de recherche..." && cmboxCategory.Text != "Toutes Catégories")
            {

                for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
                {
                    if (Controller.TransfercategoryData()[i, 1] == cmboxCategory.Text)
                    {
                        Controller.SetMouvementTableFilter(Controller.TransfercategoryData()[i, 0], txtboxSearch.Text);
                        break;
                    }
                }
            }

            if ((txtboxSearch.Text == "Zone de recherche..." || txtboxSearch.Text.Length == 0) && cmboxCategory.Text != "Toutes Catégories")
            {
                for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
                {
                    if (Controller.TransfercategoryData()[i, 1] == cmboxCategory.Text)
                    {
                        Controller.SetMouvementTableFilter(Controller.TransfercategoryData()[i, 0], null);
                        break;
                    }
                }
            }

            if (txtboxSearch.Text != "Zone de recherche..." && cmboxCategory.Text == "Toutes Catégories")
            {
                Controller.SetMouvementTableFilter(null, txtboxSearch.Text);
            }

            if ((txtboxSearch.Text == "Zone de recherche..." || txtboxSearch.Text.Length == 0) && cmboxCategory.Text == "Toutes Catégories")
            {
                Controller.SetMouvementTableFilter(null, null);
            }
            
            Controller.Resetnumberofpage();

            lblNumberpages.Text = Convert.ToString(Controller.Getnumberofpage());

            Controller.AfficherPageMouvement(Controller.Getnumberofpage(), this, pnlMouvementbutton);
        }
    }
}
