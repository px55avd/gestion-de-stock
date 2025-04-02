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
    public partial class ViewnewUser : Form
    {
        public ViewnewUser()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Afficher la vue du compte utilisateur
            Controller.changeView("View");
        }

        private void btnvalidnewArticle_Click(object sender, EventArgs e)
        {
            //INteger nouvel utilisateur dans la db avec les info des texte box, 0 pour ne pas avoir les droit admin.
            Controller.IntergerdataUser(txtboxFirstname.Text, txtboxName.Text, txtboxLogin.Text, txtboxPassword.Text, 0);


            // Afficher la vue du compte utilisateur
            Controller.changeView("View");

            //Retour à la page de connexion
            this.Hide();
        }
    }
}
