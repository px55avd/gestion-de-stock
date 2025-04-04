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
    public partial class ViewoneArticle : Form
    {
        public ViewoneArticle()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard", FindForm());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle", FindForm());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount", FindForm());
        }

        private void btnMouvement_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement", FindForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Réinitailise le current user
            for (int i = 0; i < Controller.SetcurrentUser().Length; i++)
            {
                Controller.SetcurrentUser()[i] = "";
            }

            
            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
        }

        private void ViewoneArticle_Activated(object sender, EventArgs e)
        {
            txtboxName.Text = "";
            txtboxDescription.Text = "";
            txtboxHowmany.Text = "";
            txtboxPrice.Text = "";
            cmboxCategory.Items.Clear();


            lblNamearticle.Text = Controller.SetcurrentArticle()[1];
            txtboxName.Text = Controller.SetcurrentArticle()[1];
            txtboxDescription.Text = Controller.SetcurrentArticle()[2];
            txtboxHowmany.Text = Controller.SetcurrentArticle()[3];
            txtboxPrice.Text = Controller.SetcurrentArticle()[4];

            for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
            {
                if (Controller.TransfercategoryData()[i,0] ==Controller.SetcurrentArticle()[5])
                {
                    cmboxCategory.Text = Controller.TransfercategoryData()[i, 1];
                }
                else
                {
                    cmboxCategory.Items.Add(Controller.TransfercategoryData()[i, 1]);
                }
            }

            txtboxHowmany.Enabled = false;
        }

        private void btnUpdatearticle_Click(object sender, EventArgs e)
        {
            if (lblNamearticle.Text == Controller.SetcurrentArticle()[1] && txtboxName.Text == Controller.SetcurrentArticle()[1] && txtboxDescription.Text == Controller.SetcurrentArticle()[2]
                && txtboxHowmany.Text == Controller.SetcurrentArticle()[3] && txtboxPrice.Text == Controller.SetcurrentArticle()[4])
            {
                MessageBox.Show("Les données n'ont pas été modifiées !!!");
            }
            else
            {
                for (int i = 0; i < Controller.TransfercategoryData().GetLength(0); i++)
                {
                    if (Controller.TransfercategoryData()[i, 1] == cmboxCategory.Text)
                    {
                        Controller.Updatearticle(txtboxName.Text, txtboxDescription.Text, txtboxPrice.Text, Controller.TransfercategoryData()[i, 0]);


                        MessageBox.Show("Êtes-vous sûr de vouloir modifier cette article ?", "Attention, Modification",MessageBoxButtons.YesNo);
                        // Afficher la vue du compte utilisateur
                        Controller.changeView("Viewarticle", FindForm());
                    }
                }
            }
        }
    }
}
