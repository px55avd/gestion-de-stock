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
            txtboxFirstname.Text = Controller.GetcurrentUser()[1];
            txtboxName.Text = Controller.GetcurrentUser()[2];
            txtboxLogin.Text = Controller.GetcurrentUser()[3];  
            txtboxPassword.Text = Controller.GetcurrentUser()[4];
        }

        private void btnUpdateuser_Click(object sender, EventArgs e)
        {
            if (txtboxFirstname.Text == Controller.GetcurrentUser()[1] && txtboxName.Text == Controller.GetcurrentUser()[2] && txtboxLogin.Text == Controller.GetcurrentUser()[3]
                && txtboxPassword.Text == Controller.GetcurrentUser()[4])
            {
                MessageBox.Show("Les données n'ont pas été modifiées !!!");
            }
            else
            {
                Controller.UpdatedataUser(Controller.GetcurrentUser()[0], txtboxFirstname.Text, txtboxName.Text, txtboxLogin.Text, txtboxPassword.Text);

                Controller.Setcurrentuser(Controller.GetcurrentUser()[0], txtboxFirstname.Text, txtboxName.Text, txtboxLogin.Text, txtboxPassword.Text, Controller.GetcurrentUser()[5]);

                txtboxFirstname.Text = Controller.GetcurrentUser()[1];
                txtboxName.Text = Controller.GetcurrentUser()[2];
                txtboxLogin.Text = Controller.GetcurrentUser()[3];
                txtboxPassword.Text = Controller.GetcurrentUser()[4];

                MessageBox.Show("Êtes-vous sûr de vouloir modifier vos informations ?", "Attention, Modification", MessageBoxButtons.YesNo);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //
            Controller.DeleteUserdata(Controller.GetcurrentUser()[0]);

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
            for (int i = 0; i < Controller.GetcurrentUser().Length; i++)
            {
                Controller.GetcurrentUser()[i] = "";
            }

            // Afficher la vue du compte utilisateur
            Controller.changeView("View", FindForm());
        }
    }
}
