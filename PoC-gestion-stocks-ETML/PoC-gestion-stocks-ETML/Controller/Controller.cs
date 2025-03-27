using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoC_gestion_stocks_ETML.Model;
using PoC_gestion_stocks_ETML.Views;

namespace PoC_gestion_stocks_ETML.Controller
{
    public class Controller
    {
        // Déclarations des différentes vues utilisées par le contrôleur.
        private View _view;
        private Viewdashboard _viewDashboard;
        private Viewarticle _viewarticle;
        private ViewMouvement _viewmouvement;
        private ViewnewArticle _viewnewArticle;
        private ViewAccount _viewaccount;
        private ViewoneArticle _viewoneArticle;
        private ViewnewUser _viewnewUser;
        private ViewnewMouvement _viewnewMouvement;

        // Référence au modèle utilisé par le contrôleur.
        private Model.Model _model;

        //Variable privée
        private string _currrentUserindex;
        private string _currrentUserfirstname;
        private string _currrentUserName;
        private string _currrentUserlogin;
        private string _currrentUserPaswword;
        private string _currrentUserrole;

        private string[] _currentUser = new string[6];

        public Controller(View view, Model.Model model,  Viewdashboard viewdashborad, Viewarticle viewarticle, ViewMouvement viewmouvement,
            ViewnewArticle viewnewArticle, ViewAccount viewaccount, ViewoneArticle viewoneArticle, ViewnewUser viewnewUser, ViewnewMouvement viewnewMouvement)
        {
            // Initialisation des références aux vues et au modèle.
            _model = model;
            _model.Controller = this;

            // Vue principale
            _view = view;
            _view.Controller = this;

            _viewDashboard = viewdashborad;
            _viewDashboard.Controller = this;

            _viewarticle = viewarticle;
            _viewarticle.Controller = this;

            _viewmouvement = viewmouvement;
            _viewmouvement.Controller = this;

            _viewnewArticle = viewnewArticle;
            _viewnewArticle.Controller = this;

            _viewaccount = viewaccount;
            _viewaccount.Controller = this;

            _viewoneArticle = viewoneArticle;
            _viewoneArticle.Controller = this;

            _viewnewUser = viewnewUser;
            _viewnewUser.Controller = this;
            
            _viewnewMouvement = viewnewMouvement;
            _viewnewMouvement.Controller = this;

            
        }

        public void changeView(string nameview)
        {
            if (nameview == "View")
            {
                _view.Show();
            }
            else if (nameview == "ViewAccount")
            {
                _viewaccount.Show();
            }
            else if (nameview == "Viewarticle")
            {
                _viewarticle.Show();
            }
            else if (nameview == "Viewdashboard")
            {
                _viewDashboard.Show();
            } 
            else if (nameview == "ViewMouvement")
            {
                _viewmouvement.Show();
            }
            else if (nameview == "ViewnewArticle")
            {
                _viewnewArticle.Show();
            }
            else if (nameview == "ViewnewMouvement")
            {
                _viewnewMouvement.Show();
            }else if (nameview == "ViewnewUser")
            {
                _viewnewUser.Show();
            }
            else if (nameview == "ViewoneArticle")
            {
                _viewoneArticle.Show();
            }


        }

        /// <summary>
        /// 
        /// </summary>
        public void TestconnectionDatabase()
        {
            _model.TestConnection();
        }

        /// <summary>
        /// 
        /// </summary>
        public string[,] Transferdata()
        {
            return _model.Getdata();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="firstname"></param>
        /// <param name="address"></param>
        public void Intergerdata(string firstname, string name, string login, string password, int role)
        {
            _model.SaveNewuser(firstname, name, login, password, role);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstname"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public void Updatedata(string id, string firstname, string name, string address)
        {
            _model.updateUser(id, firstname, name, address);


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Deletedata(string id)
        {
            _model.DeleteUser(id);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="currrentUserindex"></param>
        /// <param name="currrentUserfirstname"></param>
        /// <param name="currrentUserName"></param>
        /// <param name="currrentUserlogin"></param>
        /// <param name="currrentUserPaswword"></param>
        /// <param name="currrentUserrole"></param>
        public void Getcurrentuser(string currrentUserindex, string currrentUserfirstname ,string currrentUserName   ,string currrentUserlogin ,string currrentUserPaswword ,string currrentUserrole)
        {

              //_currrentUserindex = currrentUserindex;
              //_currrentUserfirstname = currrentUserfirstname;
              //_currrentUserName = currrentUserName;
              //_currrentUserlogin = currrentUserlogin;
              //_currrentUserPaswword = currrentUserPaswword;
              //_currrentUserrole = currrentUserrole;

            _currentUser[0] = currrentUserindex;
            _currentUser[1] = currrentUserfirstname;
            _currentUser[2] = currrentUserName;
            _currentUser[3] = currrentUserlogin;
            _currentUser[4] = currrentUserPaswword;
            _currentUser[5] = currrentUserrole;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] SetcurrentUser()
        {
            //
            return _currentUser;
        }



    }
}
