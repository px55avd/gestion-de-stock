namespace PoC_gestion_stocks_ETML
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestconnexionDatabase_Click(object sender, EventArgs e)
        {
            Controller.TestconnectionDatabase();
        }

        private void btnRegisternewUser_Click(object sender, EventArgs e)
        {
            if (txtboxFirstname.Text != "" || txtboxName.Text != "" || txtboxAddress.Text !="" )
            {
                Controller.Intergerdata(txtboxFirstname.Text, txtboxName.Text, txtboxAddress.Text);

                txtboxFirstname.Text = "";
                txtboxName.Text = "";
                txtboxAddress.Text = "";

                View_Activated(sender, e);
            }
            else
            {
                MessageBox.Show("Un champs est vide");
            }
            
        }

        private void btnUpdateuser_Click(object sender, EventArgs e)
        {
            Controller.ShowViewupdateAnsdelete();
        }

        private void View_Activated(object sender, EventArgs e)
        {
            lstviewData.Clear();
            View_Load( sender, e); 
        }



        private void View_Load(object sender, EventArgs e)
        {
            lstviewData.Clear();

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
    }
}