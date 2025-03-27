using System;
using System.Windows.Forms;
using PoC_gestion_stocks_ETML.Views;

namespace PoC_gestion_stocks_ETML
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            View view = new View();

            Viewdashboard viewdashborad = new Viewdashboard();
            Viewarticle viewarticle = new Viewarticle();
            ViewMouvement viewMouvement = new ViewMouvement();
            ViewnewArticle viewnewArticle = new ViewnewArticle();
            ViewAccount viewAccount = new ViewAccount();
            ViewoneArticle viewoneArticle = new ViewoneArticle();
            ViewnewUser viewnewUser = new ViewnewUser();
            ViewnewMouvement viewnewMouvement = new ViewnewMouvement();

            Model.Model model = new Model.Model();

            Controller.Controller controller = new Controller.Controller(view, model, viewdashborad, viewarticle, viewMouvement, viewnewArticle, viewAccount, viewoneArticle,
                viewnewUser, viewnewMouvement);



            Application.Run(view);
        }
    }
}