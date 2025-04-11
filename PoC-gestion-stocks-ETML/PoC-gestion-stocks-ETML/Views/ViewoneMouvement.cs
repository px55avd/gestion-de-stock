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
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard", FindForm());
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle", FindForm());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement", FindForm());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewAccount", FindForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Réinitailise le current user
            for (int i = 0; i < Controller.GetcurrentUser().Length; i++)
            {
                Controller.GetcurrentUser()[i] = "";
            }

            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
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
                if (Controller.TransferuserData()[i, 0] == Controller.GetcurrentMouvement()[4])
                {
                    txtboxNamefirstname.Text = Controller.TransferuserData()[i, 2] + " " + Controller.TransferuserData()[i, 1];
                }
            }


            txtboxDate.Text = Convert.ToDateTime(Controller.GetcurrentMouvement()[1]).ToString("dd.MM.yyyy");
            txtboxHowmany.Text = Controller.GetcurrentMouvement()[3];

            for (int i = 0; i < Controller.TransferarticleData().GetLength(0); i++)
            {
                if (Controller.TransferarticleData()[i, 0] == Controller.GetcurrentMouvement()[4])
                {
                    txtboxArticle.Text = Controller.TransferarticleData()[i, 1];
                    lblNamearticle.Text = Controller.TransferarticleData()[i, 1];
                }
            }


            if (Convert.ToBoolean(Controller.GetcurrentMouvement()[2]) == true)
            {
                rdbtnEntry.Checked = true;
                rdbtnExit.Checked = false;
            }
            else if (Convert.ToBoolean(Controller.GetcurrentMouvement()[2]) == false)
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
