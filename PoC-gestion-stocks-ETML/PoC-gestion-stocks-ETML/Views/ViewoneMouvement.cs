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
    public partial class ViewoneMouvement : Form
    {
        public ViewoneMouvement()
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

        private void btnArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewArticle");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Réinitailise le current user
            for (int i = 0; i < Controller.SetcurrentUser().Length; i++)
            {
                Controller.SetcurrentUser()[i] = "";
            }


            // Afficher la vue du compte utilisateur
            Controller.changeView("View");
            this.Hide();

        }

        private void ViewoneMouvement_Activated(object sender, EventArgs e)
        {
            txtboxNamefirstname.Text = "";
            txtboxDate.Text = "";
            txtboxHowmany.Text = "";
            txtboxArticle.Text = "";
            rdbtnEntry.Checked = false;
            rdbtnExit.Checked = false;
            


            for (int i = 0; i < Controller.TransferuserData().GetLength(0); i++)
            {
                if (Controller.TransferuserData()[i, 0] == Controller.SetcurrentMouvement()[4])
                {
                    txtboxNamefirstname.Text = Controller.TransferuserData()[i, 2] + " " + Controller.TransferuserData()[i, 1];
                }
            }


            txtboxDate.Text = Controller.SetcurrentMouvement()[1];
            txtboxHowmany.Text = Controller.SetcurrentMouvement()[3];

            for (int i = 0; i < Controller.TransferarticleData().GetLength(0); i++)
            {
                if (Controller.TransferarticleData()[i, 0] == Controller.SetcurrentMouvement()[4])
                {
                    txtboxArticle.Text = Controller.TransferarticleData()[i, 1];
                    lblNamearticle.Text = Controller.TransferarticleData()[i, 1];
                }
            }


            if (Convert.ToBoolean(Controller.SetcurrentMouvement()[2]) == true)
            {
                rdbtnEntry.Checked = true;
                rdbtnExit.Checked = false;
            }
            else if (Convert.ToBoolean(Controller.SetcurrentMouvement()[2]) == false)
            {
                rdbtnEntry.Checked = false;
                rdbtnExit.Checked = true;
            }


            txtboxNamefirstname.Enabled = false;
            txtboxDate.Enabled = false;
            txtboxHowmany.Enabled = false;
            txtboxArticle.Enabled = false;
            rdbtnEntry.Enabled = false;
            rdbtnExit.Enabled = false;


        }
    }
}
