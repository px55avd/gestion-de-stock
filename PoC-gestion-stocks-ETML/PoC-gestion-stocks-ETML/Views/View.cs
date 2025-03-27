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


        private void btnNewuser_Click(object sender, EventArgs e)
        {
            Controller.changeView("ViewnewUser");
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[,] data;

            data = Controller.Transferdata();


            if (txtboxUsename.Text == "" && txtboxPassword.Text == "")
            {

                MessageBox.Show("Champs vide(s) !!!");
            }

            for (int i = 0; i < data.Length/ 6; i++)
            {
                for (int j = 0; j < data.Length / (data.Length / 6); j++)
                {
                    if (txtboxUsename.Text == data[i, j] && txtboxPassword.Text == data[i, j+ 1]) 
                    {

                        Controller.Getcurrentuser(data[i,0], data[i, 1], data[i, 2], data[i, 3], data[i, 4], data[i, 5]);
                        MessageBox.Show("Connexion réussi");
                        this.Hide();
                        Controller.changeView("Viewdashboard");
                    }
                }
            }

            txtboxUsename.Text = "";
            txtboxPassword.Text = "";

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}