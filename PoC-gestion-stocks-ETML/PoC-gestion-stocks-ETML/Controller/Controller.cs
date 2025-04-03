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
        private ViewoneMouvement _viewoneMouvement;

        // Référence au modèle utilisé par le contrôleur.
        private Model.Model _model;

        //Variable privée
        private string[] _currentUser = new string[6];
        private string[] _currentarticle = new string[6];
        private string[] _currentMouvemnt = new string[6];


        // Variables globales pour la pagination
        private int _pageActuelle = 0;
        private const int _mouvementsParPage = 10; // Nombre total d’articles par page
        private const int _colonnes = 2; // Nombre de colonnes
        private const int _espaceX = 210, espaceY = 50; // Espacement des boutons
        private string[,] _mouvements; // Stocke les articles

        private const int _articlesParPage = 10; // Nombre total d’articles par page
        private string[,] _articles; // Stocke les articles

        public Controller(View view, Model.Model model, Viewdashboard viewdashborad, Viewarticle viewarticle, ViewMouvement viewmouvement,
            ViewnewArticle viewnewArticle, ViewAccount viewaccount, ViewoneArticle viewoneArticle, ViewnewUser viewnewUser, ViewnewMouvement viewnewMouvement, ViewoneMouvement viewoneMouvement)
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

            _viewoneMouvement = viewoneMouvement;
            _viewoneMouvement.Controller = this;

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
            }
            else if (nameview == "ViewnewUser")
            {
                _viewnewUser.Show();
            }
            else if (nameview == "ViewoneArticle")
            {
                _viewoneArticle.Show();
            }
            else if (nameview == "ViewoneMouvement")
            {
                _viewoneMouvement.Show();
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
        public string[,] TransferuserData()
        {
            return _model.GetuserData();

        }


        /// <summary>
        /// 
        /// </summary>
        public string[,] TransferarticleData()
        {
            return _model.GetarticleData();

        }

        /// <summary>
        /// 
        /// </summary>
        public string[,] TransfercategoryData()
        {
            return _model.GetcategoryData();

        }

        /// <summary>
        /// 
        /// </summary>
        public string[,] TransfermouvementData()
        {
            return _model.GetMouvementData();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="name"></param>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        public void IntergerdataUser(string firstname, string name, string login, string password, int role)
        {
            _model.SaveNewuser(firstname, name, login, password, role);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="unitPrice"></param>
        /// <param name="categoryID"></param>
        public void IntergerdataArticle(string name, string description, string quantity, string unitPrice, string categoryID)
        {
            _model.SaveNewArticle(name, description, quantity, unitPrice, categoryID);
        }


        public void IntergerdataMouvement(string Mouvementdatetime, string Mouvementtype, string Mouvementquantity, string MouvementUserID, string MouvementArticleID)
        {
            _model.SaveNewMouvement(Mouvementdatetime, Mouvementtype, Mouvementquantity, MouvementUserID, MouvementArticleID);
        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstname"></param>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public void UpdatedataUser(string id, string firstname, string name, string address)
        {
            _model.updateUser(id, firstname, name, address);


        }

        public void UpdatedataArticlequantity(string id, string quantity)
        {
            _model.updateArticleqiuantity(id, quantity);


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUserdata(string id)
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
        public void Getcurrentuser(string currrentUserindex, string currrentUserfirstname, string currrentUserName, string currrentUserlogin, string currrentUserPaswword, string currrentUserrole)
        {

            _currentUser[0] = currrentUserindex;
            _currentUser[1] = currrentUserfirstname;
            _currentUser[2] = currrentUserName;
            _currentUser[3] = currrentUserlogin;
            _currentUser[4] = currrentUserPaswword;
            _currentUser[5] = currrentUserrole;

        }

        public void Getcurrentarticle(string currrentArtileindex, string currrentArticleName, string currrentArticledescription, string currrentArticlequantity, string currrentArticleunitPrice, string currrentArticleCatégorie)
        {

            _currentarticle[0] = currrentArtileindex;
            _currentarticle[1] = currrentArticleName;
            _currentarticle[2] = currrentArticledescription;
            _currentarticle[3] = currrentArticlequantity;
            _currentarticle[4] = currrentArticleunitPrice;
            _currentarticle[5] = currrentArticleCatégorie;

        }


        public void GetcurrentMouvment(string currrentMouvementindex, string currrentMouvementdatetime, string currrentMouvementtype, string currrentMouvementquantity, string currrentMouvementUser, string currrentMouvementArticle)
        {

            _currentMouvemnt[0] = currrentMouvementindex;
            _currentMouvemnt[1] = currrentMouvementdatetime;
            _currentMouvemnt[2] = currrentMouvementtype;
            _currentMouvemnt[3] = currrentMouvementquantity;
            _currentMouvemnt[4] = currrentMouvementUser;
            _currentMouvemnt[5] = currrentMouvementArticle;

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] SetcurrentArticle()
        {
            //
            return _currentarticle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] SetcurrentMouvement()
        {
            //
            return _currentMouvemnt;
        }


        public void AfficherPageMouvement(int page, Form form, Panel pnl)
        {
            pnl.Controls.Clear(); // Efface les anciens boutons

            int nbArticles = _mouvements.GetLength(0);
            int debut = page * _mouvementsParPage;
            int fin = Math.Min(debut + _mouvementsParPage, nbArticles);

            for (int i = debut; i < fin; i++)
            {
                string mouvementName = "";

                mouvementName += $"{_mouvements[i, 3]}";

                for (int j = 0; j < TransferarticleData().GetLength(0); j++)
                {
                    if (_mouvements[i, 5] == TransferarticleData()[j, 0])
                    {
                        mouvementName += " " + TransferarticleData()[j, 1]; // Nom de l'article
                    }
                }


                if (Convert.ToBoolean(_mouvements[i, 2]) == true)
                {
                    mouvementName += ", Entrée"; //type
                }
                else if (Convert.ToBoolean(_mouvements[i, 2]) == false)
                {
                    mouvementName += ", Sortie"; //type
                }


                mouvementName += $", {Convert.ToDateTime(_mouvements[i, 1]).ToString("dd.MM.yyyy")}"; //date

                Button btn = new Button();
                btn.Text = mouvementName;
                btn.Size = new Size(200, 40);

                int colonne = (i - debut) % _colonnes;
                int ligne = (i - debut) / _colonnes;

                btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                // Événement du bouton pour récupérer les infos de l'article
                int index = i; // Sauvegarde l'index pour récupérer l'article
                btn.Click += (s, args) => GetcurrentMouvment(_mouvements[index, 0], _mouvements[index, 1], _mouvements[index, 2], _mouvements[index, 3], _mouvements[index, 4], _mouvements[index, 5]);
                btn.Click += (s, args) => form.Hide();
                btn.Click += (s, args) => changeView("ViewoneMouvement");


                pnl.Controls.Add(btn);
            }

        }

        public void AfficherPageArticle(int page, Form form, Panel pnl)
        {
            pnl.Controls.Clear(); // Efface les anciens boutons

            int nbArticles = _articles.GetLength(0);
            int debut = page * _articlesParPage;
            int fin = Math.Min(debut + _articlesParPage, nbArticles);

            for (int i = debut; i < fin; i++)
            {
                string articleName = _articles[i, 1]; // Nom de l'article

                Button btn = new Button();
                btn.Text = articleName;
                btn.Size = new Size(200, 40);

                int colonne = (i - debut) % _colonnes;
                int ligne = (i - debut) / _colonnes;

                btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                // Événement du bouton pour récupérer les infos de l'article
                int index = i; // Sauvegarde l'index pour récupérer l'article
                btn.Click += (s, args) => Getcurrentarticle(_articles[index, 0], _articles[index, 1], _articles[index, 2], _articles[index, 3], _articles[index, 4], _articles[index, 5]);
                btn.Click += (s, args) => form.Hide();
                btn.Click += (s, args) => changeView("ViewoneArticle");



                pnl.Controls.Add(btn);
            }
        }

        public void AfficherPageMouvementinDashboard(Form form, Panel pnl)
        {
            pnl.Controls.Clear(); // Efface les anciens boutons

            int nbArticles = _mouvements.GetLength(0);
            int debut = 0;
            int fin = 6;

            for (int i = debut; i < fin; i++)
            {
                string mouvementName = "";

                mouvementName += $"{_mouvements[i, 3]}";

                for (int j = 0; j < TransferarticleData().GetLength(0); j++)
                {
                    if (_mouvements[i, 5] == TransferarticleData()[j, 0])
                    {
                        mouvementName += " " + TransferarticleData()[j, 1]; // Nom de l'article
                    }
                }


                if (Convert.ToBoolean(_mouvements[i, 2]) == true)
                {
                    mouvementName += ", Entrée"; //type
                }
                else if (Convert.ToBoolean(_mouvements[i, 2]) == false)
                {
                    mouvementName += ", Sortie"; //type
                }


                mouvementName += $", {Convert.ToDateTime(_mouvements[i, 1]).ToString("dd.MM.yyyy")}"; //date

                Button btn = new Button();
                btn.Text = mouvementName;
                btn.Size = new Size(200, 40);

                int colonne = (i - debut) % _colonnes;
                int ligne = (i - debut) / _colonnes;

                btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                // Événement du bouton pour récupérer les infos de l'article
                int index = i; // Sauvegarde l'index pour récupérer l'article
                btn.Click += (s, args) => GetcurrentMouvment(_mouvements[index, 0], _mouvements[index, 1], _mouvements[index, 2], _mouvements[index, 3], _mouvements[index, 4], _mouvements[index, 5]);
                btn.Click += (s, args) => form.Hide();
                btn.Click += (s, args) => changeView("ViewoneMouvement");


                pnl.Controls.Add(btn);
            }
        }

        public int Getnumberofpage()
        {
            return _pageActuelle;
        }

        public int GetnumberofmouvementBypage()
        {
            return _mouvementsParPage;
        }

        public int GetnumberofarticleBypage()
        {
            return _articlesParPage;
        }

        public void Plusnumberofpage()
        {
            _pageActuelle++;
        }

        public void Minusnumberofpage()
        {
            _pageActuelle--;
        }

        public void Resetnumberofpage()
        {
            _pageActuelle = 0;
        }


        public void SetMouvementTable()
        {
            _mouvements = TransfermouvementData(); ;
        }

        public void SetarticleTable()
        {
            _articles = TransferarticleData(); ;
        }


    }
}
