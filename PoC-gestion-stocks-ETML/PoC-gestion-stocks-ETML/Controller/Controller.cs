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

        private int _totalArticle = 0;
        private int _articleCritical = 3;
        private int _article = 0;
        private int _criticalAriclecount = 0;


        // Variables globales pour la pagination
        private int _pageActuelle = 0;
        private const int _mouvementsParPage = 10; // Nombre total d’articles par page
        private const int _colonnes = 2; // Nombre de colonnes
        private const int _espaceX = 210, espaceY = 50; // Espacement des boutons
        private string[,] _mouvements; // Stocke les articles

        private const int _articlesParPage = 10; // Nombre total d’articles par page
        private string[,] _articles; // Stocke les articles

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        /// <param name="viewdashborad"></param>
        /// <param name="viewarticle"></param>
        /// <param name="viewmouvement"></param>
        /// <param name="viewnewArticle"></param>
        /// <param name="viewaccount"></param>
        /// <param name="viewoneArticle"></param>
        /// <param name="viewnewUser"></param>
        /// <param name="viewnewMouvement"></param>
        /// <param name="viewoneMouvement"></param>
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameview"></param>
        /// <param name="form"></param>
        public void changeView(string nameview, Form form)
        {
            if (nameview == "View")
            {   
                form.Hide();
                _view.Show();
            }
            else if (nameview == "ViewAccount")
            {
                form.Hide();
                _viewaccount.Show();
            }
            else if (nameview == "Viewarticle")
            {
                form.Hide();
                _viewarticle.Show();
            }
            else if (nameview == "Viewdashboard")
            {
                form.Hide();
                _viewDashboard.Show();
            }
            else if (nameview == "ViewMouvement")
            {
                form.Hide();
                _viewmouvement.Show();
            }
            else if (nameview == "ViewnewArticle")
            {
                form.Hide();
                _viewnewArticle.Show();
            }
            else if (nameview == "ViewnewMouvement")
            {
                form.Hide();
                _viewnewMouvement.Show();
            }
            else if (nameview == "ViewnewUser")
            {
                form.Hide();
                _viewnewUser.Show();
            }
            else if (nameview == "ViewoneArticle")
            {
                form.Hide();
                _viewoneArticle.Show();
            }
            else if (nameview == "ViewoneMouvement")
            {
                form.Hide();
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
        /// <param name="idCategory"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string[,] TransfermouvementDataFilter(string idCategory, string name)
        {
            return _model.GetMouvementDataFilter(idCategory, name);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mouvementdatetime"></param>
        /// <param name="Mouvementtype"></param>
        /// <param name="Mouvementquantity"></param>
        /// <param name="MouvementUserID"></param>
        /// <param name="MouvementArticleID"></param>
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
        public void UpdatedataUser(string id, string firstname, string name, string login, string password)
        {
            _model.updateUser(id, firstname, name, login, password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quantity"></param>
        public void UpdatedataArticlequantity(string id, string quantity)
        {
            _model.updateArticleqiuantity(id, quantity);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="unitPrice"></param>
        /// <param name="categoryID"></param>
        public void Updatearticle(string name, string description, string unitPrice, string categoryID)
        {
            _model.updateArticle(GetcurrentArticle()[0], name, description, unitPrice, categoryID);
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
        public void Setcurrentuser(string currrentUserindex, string currrentUserfirstname, string currrentUserName, string currrentUserlogin, string currrentUserPaswword, string currrentUserrole)
        {

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
        /// <param name="currrentArtileindex"></param>
        /// <param name="currrentArticleName"></param>
        /// <param name="currrentArticledescription"></param>
        /// <param name="currrentArticlequantity"></param>
        /// <param name="currrentArticleunitPrice"></param>
        /// <param name="currrentArticleCatégorie"></param>
        public void Setcurrentarticle(string currrentArtileindex, string currrentArticleName, string currrentArticledescription, string currrentArticlequantity, string currrentArticleunitPrice, string currrentArticleCatégorie)
        {

            _currentarticle[0] = currrentArtileindex;
            _currentarticle[1] = currrentArticleName;
            _currentarticle[2] = currrentArticledescription;
            _currentarticle[3] = currrentArticlequantity;
            _currentarticle[4] = currrentArticleunitPrice;
            _currentarticle[5] = currrentArticleCatégorie;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currrentMouvementindex"></param>
        /// <param name="currrentMouvementdatetime"></param>
        /// <param name="currrentMouvementtype"></param>
        /// <param name="currrentMouvementquantity"></param>
        /// <param name="currrentMouvementUser"></param>
        /// <param name="currrentMouvementArticle"></param>
        public void SetcurrentMouvment(string currrentMouvementindex, string currrentMouvementdatetime, string currrentMouvementtype, string currrentMouvementquantity, string currrentMouvementUser, string currrentMouvementArticle)
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
        public string[] GetcurrentUser()
        {
            //
            return _currentUser;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetcurrentArticle()
        {
            //
            return _currentarticle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] GetcurrentMouvement()
        {
            //
            return _currentMouvemnt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="form"></param>
        /// <param name="pnl"></param>
        public void AfficherPageMouvement(int page, Form form, Panel pnl)
        {
            pnl.Controls.Clear(); // Efface les anciens boutons

            SetarticleTable();

            int nbArticles = _mouvements.GetLength(0);
            int debut = page * _mouvementsParPage;
            int fin = Math.Min(debut + _mouvementsParPage, nbArticles);

            for (int i = debut; i < fin; i++)
            {
                string mouvementName = "";

                mouvementName += $"{_mouvements[i, 3]}";

                for (int j = 0; j < _articles.GetLength(0); j++)
                {
                    if (_mouvements[i, 5] == _articles[j, 0])
                    {
                        mouvementName += " " + _articles[j, 1]; // Nom de l'article
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

                if (_mouvements[i,0] != null)
                {
                    Button btn = new Button();
                    btn.Text = mouvementName;
                    btn.Size = new Size(200, 40);

                    int colonne = (i - debut) % _colonnes;
                    int ligne = (i - debut) / _colonnes;

                    btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                    // Événement du bouton pour récupérer les infos de l'article
                    int index = i; // Sauvegarde l'index pour récupérer l'article
                    btn.Click += (s, args) => SetcurrentMouvment(_mouvements[index, 0], _mouvements[index, 1], _mouvements[index, 2], _mouvements[index, 3], _mouvements[index, 4], _mouvements[index, 5]);
                    btn.Click += (s, args) => form.Hide();
                    btn.Click += (s, args) => changeView("ViewoneMouvement", form);
                    
                    pnl.Controls.Add(btn);

                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="form"></param>
        /// <param name="pnl"></param>
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
                btn.Click += (s, args) => Setcurrentarticle(_articles[index, 0], _articles[index, 1], _articles[index, 2], _articles[index, 3], _articles[index, 4], _articles[index, 5]);
                btn.Click += (s, args) => form.Hide();
                btn.Click += (s, args) => changeView("ViewoneArticle", form);



                pnl.Controls.Add(btn);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        /// <param name="pnl"></param>
        public void AfficherPageMouvementinDashboard(Form form, Panel pnl)
        {
            pnl.Controls.Clear(); // Efface les anciens boutons

            SetarticleTable();

            int nbMouvements = _mouvements.GetLength(0);
            int nbAffiches = 8; // Par exemple 15 derniers
            int debut = nbMouvements - 1;
            int fin = nbMouvements - nbAffiches;

            for (int i = debut; i >= fin; i--)
            {
                string mouvementName = "";

                mouvementName += $"{_mouvements[i, 3]}";

                for (int j = 0; j < _articles.GetLength(0); j++)
                {
                    if (_mouvements[i, 5] == _articles[j, 0])
                    {
                        mouvementName += " " + _articles[j, 1]; // Nom de l'article
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

                int ligne = (debut - i) / _colonnes;
                int colonne = (debut - i) % _colonnes;

                btn.Location = new Point(10 + colonne * _espaceX, 10 + ligne * espaceY);

                // Événement du bouton pour récupérer les infos de l'article
                int index = i; // Sauvegarde l'index pour récupérer l'article
                btn.Click += (s, args) => SetcurrentMouvment(_mouvements[index, 0], _mouvements[index, 1], _mouvements[index, 2], _mouvements[index, 3], _mouvements[index, 4], _mouvements[index, 5]);
                btn.Click += (s, args) => form.Hide();
                btn.Click += (s, args) => changeView("ViewoneMouvement", form);


                pnl.Controls.Add(btn);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Getnumberofpage()
        {
            return _pageActuelle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetnumberofmouvementBypage()
        {
            return _mouvementsParPage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetnumberofarticleBypage()
        {
            return _articlesParPage;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Plusnumberofpage()
        {
            _pageActuelle++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Minusnumberofpage()
        {
            _pageActuelle--;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Resetnumberofpage()
        {
            _pageActuelle = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetMouvementTable()
        {
            
            _mouvements = TransfermouvementData(); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategory"></param>
        /// <param name="name"></param>
        public void SetMouvementTableFilter(string idCategory, string name)
        {
            
            _mouvements = TransfermouvementDataFilter(idCategory, name);
        }

        /// <summary>
        /// 
        /// </summary>
        public void ResetMouvementTable()
        {
            _mouvements = new string[0, 0];
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SetarticleTable()
        {
            _articles = TransferarticleData(); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[,] GetMouvementTable()
        {
            return _mouvements;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[,] GetarticleTable()
        {
            return _articles;
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public int GettotalArticle()
        {
       
            _totalArticle = 0;

            for (int i = 0; i < TransferarticleData().GetLength(0); i++)
            {
                _totalArticle += Convert.ToInt32(TransferarticleData()[i, 3]);

            }

            return _totalArticle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetcriticalArticle()
        {
            _article = 0;
            _criticalAriclecount = 0;   

            for (int i = 0; i < TransferarticleData().GetLength(0); i++)
            {
                _article = Convert.ToInt32(TransferarticleData()[i, 3]);

                if (_article < _articleCritical)
                {
                    _criticalAriclecount++;
                }
            }

            return _criticalAriclecount;

        }
    }
}
