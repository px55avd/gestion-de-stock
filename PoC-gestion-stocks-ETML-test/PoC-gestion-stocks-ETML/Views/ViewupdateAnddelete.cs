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
    public partial class ViewupdateAnddelete : Form
    {
        public ViewupdateAnddelete()
        {
            InitializeComponent();
        }


        public Controller.Controller Controller { get; set; }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Controller.ShowViewtoViewupdatedelete();
        }

        private void ViewupdateAnddelete_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Controller.Readcolums().Length; i++)
            {
                if (Controller.Readcolums()[i] == "ID")
                {
                    lstviewData.Columns.Add(Controller.Readcolums()[i], 30);

                }
                else
                {
                    lstviewData.Columns.Add(Controller.Readcolums()[i], 130);
                }
            }

            // Ajoute les items
            for (int row = 0; row < Controller.Transferdata().GetLength(0); row++)
            {
                ListViewItem item = new ListViewItem(Controller.Transferdata()[row, 0]);  // La première colonne (ID)

                // Ajoute les autres colonnes comme sub-items
                for (int col = 1; col < Controller.Transferdata().GetLength(1); col++)
                {
                    item.SubItems.Add(Controller.Transferdata()[row, col]);
                }

                // Ajoute l'item à la ListView
                lstviewData.Items.Add(item);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text != "")
            {
                if (txtboxID.Text == "0" || Convert.ToInt32(txtboxID.Text) <= Controller.Transferdata().GetLength(0))
                {

                    Controller.Updatedata(txtboxID.Text, txtboxFirstname.Text, txtboxName.Text, txtboxAddress.Text);

                    txtboxID.Text = "";
                    txtboxFirstname.Text = "";
                    txtboxName.Text = "";
                    txtboxAddress.Text = "";

                    lstviewData.Clear();

                    ViewupdateAnddelete_Load(sender, e);
                }

            }
            else
            {
                MessageBox.Show("Un champs est vide");
            }
        }

        private void btnUpdateuser_Click(object sender, EventArgs e)
        {

            if (txtboxID.Text !="" || txtboxFirstname.Text != "" || txtboxName.Text != "" || txtboxAddress.Text != "")
            {
                if (txtboxID.Text == "0" || Convert.ToInt32(txtboxID.Text) <= Controller.Transferdata().GetLength(0))
                {

                    Controller.Updatedata(txtboxID.Text, txtboxFirstname.Text, txtboxName.Text, txtboxAddress.Text);

                    txtboxID.Text = "";
                    txtboxFirstname.Text = "";
                    txtboxName.Text = "";
                    txtboxAddress.Text = "";

                    lstviewData.Clear();

                    ViewupdateAnddelete_Load(sender, e);
                }

            }
            else
            {
                MessageBox.Show("Un champs est vide");
            }
        }
    }
}
