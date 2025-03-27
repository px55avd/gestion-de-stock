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
        private ViewupdateAnddelete _viewUpdatedelete;

        // Référence au modèle utilisé par le contrôleur.
        private Model.Model _model;



        public Controller(View view, Model.Model model, ViewupdateAnddelete viewUpdatedelete)
        {
            // Initialisation des références aux vues et au modèle.
            _model = model;
            _model.Controller = this;

            // Vue principale
            _view = view;
            _view.Controller = this;

            _viewUpdatedelete = viewUpdatedelete;
            _viewUpdatedelete.Controller = this;

        }

        /// <summary>
        /// Masque une fenêtre et affiche une autre.
        /// </summary>
        /// <param name="hide">La fenêtre à masquer.</param>
        /// <param name="show">La fenêtre à afficher.</param>
        public void HideShow(Form hide, Form show)
        {
            hide.Hide();
            show.Show();
        }

        /// <summary>
        /// Affiche la vue pour choisir d'utiliser ou non un passe Navigo.
        /// </summary>
        public void ShowViewupdateAnsdelete()
        {
            HideShow(_view, _viewUpdatedelete);
        }

        /// <summary>
        /// Affiche la vue pour choisir d'utiliser ou non un passe Navigo.
        /// </summary>
        public void ShowViewtoViewupdatedelete()
        {
            HideShow(_viewUpdatedelete, _view);
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
        public string[] Readcolums()
        {
            return _model.Readrows();
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
        public void Intergerdata(string firstname, string name, string address)
        {
            _model.SaveUser(firstname, name, address);
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
    }
}
