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
    public partial class ViewnewArticle : Form
    {
        public ViewnewArticle()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle");
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

        private void ViewnewArticle_Activated(object sender, EventArgs e)
        {
            cmboxCategory.Items.Clear();

            for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
            {
               cmboxCategory.Items.Add(Controller.TransfercategoryData()[i, 1]);
            }
        }

        private void btnvalidnewArticle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
            {
                if (Controller.TransfercategoryData()[i, 1] == cmboxCategory.Text)
                {
                    if (txtboxName.Text == "" || txtboxDescription.Text == "" || txtboxHowmany.Text == "" || txtboxPrice.Text == "" || cmboxCategory.Text == "")
                    {
                        MessageBox.Show("Un des champs est vide !!!");
                    }
                    else
                    {
                        Controller.IntergerdataArticle(txtboxName.Text, txtboxDescription.Text, txtboxHowmany.Text, txtboxPrice.Text, Controller.TransfercategoryData()[i, 0]);
                        cmboxCategory.Items.Clear();

                        this.Hide();
                        // Afficher la vue du compte utilisateur
                        Controller.changeView("Viewarticle");
                    }
                }

            }

        }
    }
}
