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
    public partial class ViewAccount : Form
    {
        public ViewAccount()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        private void ViewAccount_Activated(object sender, EventArgs e)
        {
            txtboxFirstname.Text = Controller.SetcurrentUser()[2];
            txtboxName.Text = Controller.SetcurrentUser()[1];
            txtboxLogin.Text = Controller.SetcurrentUser()[3];  
            txtboxPassword.Text = Controller.SetcurrentUser()[4];
        }

        private void btnUpdateuser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //
            Controller.DeleteUserdata(Controller.SetcurrentUser()[0]);

            Controller.changeView("View", FindForm());
        }

        private void btnMouvement_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement", FindForm());
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewdashboard",FindForm());
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("Viewarticle", FindForm());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.SetcurrentUser().Length; i++)
            {
                Controller.SetcurrentUser()[i] = "";
            }


            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
        }
    }
}
