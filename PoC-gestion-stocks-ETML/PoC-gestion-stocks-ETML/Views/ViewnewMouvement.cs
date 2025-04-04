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
            Controller.changeView("View", FindForm());  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Afficher la vue du compte utilisateur
            Controller.changeView("ViewMouvement",FindForm());
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Controller.changeView("Viewdashboard", FindForm());
        }

        private void btnArticle_Click(object sender, EventArgs e)
        {
            Controller.changeView("Viewarticle", FindForm());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Controller.changeView("ViewAccount", FindForm());
        }

        private void ViewnewMouvement_Activated(object sender, EventArgs e)
        {
            cmboxArticle.Items.Clear();

            for (int i = 0; i < Controller.TransferarticleData().GetLength(0); i++)
            {
                    cmboxArticle.Items.Add(Controller.TransferarticleData()[i, 1]);
            }
        }

        private void btnvalidnewMouvement_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            string IDarticle = "";
            string IDuser = Controller.SetcurrentUser()[0];
            int quantity = 0;
            int type = 0; 

            date = DateTime.Today;

            for (int i = 0; i < Controller.TransferarticleData().GetLength(0); i++)
            {
                if (cmboxArticle.Text == Controller.TransferarticleData()[i, 1])
                {
                    IDarticle = Controller.TransferarticleData()[i, 0];
                    quantity = Convert.ToInt32(Controller.TransferarticleData()[i, 3]);
                }

            }

            if(rdbtnEntry.Checked == true)
            {
                type = 1;
            }
            if(rdbtnExit.Checked == true)
            {
                type = 0;
            }


            if (rdbtnExit.Checked == false && rdbtnEntry.Checked == false)
            {
                MessageBox.Show("Vous avez oubliez de selectionner le type du mouvement !");
            }
            else if(txtboxHowmany.Text == "")
            {
                MessageBox.Show("Le champs quantité est vide !");
            }
            else if(cmboxArticle.Text == "")
            {
                MessageBox.Show("Le champs article est vide !");
            }
            else if(dtmpMouvement.Checked == false)
            {
                MessageBox.Show("La date a une valeur erroné !");
            }
            else if(dtmpMouvement.Value < date)
            {
                MessageBox.Show("Le date ne peut pas être dans le passé !");
            }
            else if(quantity < Convert.ToInt32(txtboxHowmany.Text) && rdbtnExit.Checked == true)
            {
                MessageBox.Show("La quantité disponible en stock n'est pas suffisante !");
            }
            else
            {


                Controller.IntergerdataMouvement(dtmpMouvement.Value.ToString("yyyy-MM-dd"), Convert.ToString(type), txtboxHowmany.Text, IDuser, IDarticle);
               
                if (type == 1)
                {
                    quantity += Convert.ToInt32(txtboxHowmany.Text);
                }
                if (type == 0)
                {
                    quantity -= Convert.ToInt32(txtboxHowmany.Text);
                }


                Controller.UpdatedataArticlequantity(IDarticle, Convert.ToString(quantity));

                

            }
        }


    }
}
