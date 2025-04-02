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
    public partial class ViewnewMouvement : Form
    {
        public ViewnewMouvement()
        {
            InitializeComponent();
        }

        public Controller.Controller Controller { get; set; }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.SetcurrentUser().Length; i++)
            {
                Controller.SetcurrentUser()[i] = "";
            }


            // Afficher la vue du compte utilisateur
            this.Hide();
            Controller.changeView("View");
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement");
            
        }
    }
}
