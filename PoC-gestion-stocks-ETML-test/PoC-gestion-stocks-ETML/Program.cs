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

            ViewupdateAnddelete viewupdateAnddelete = new ViewupdateAnddelete();




            Model.Model model = new Model.Model();

            Controller.Controller controller = new Controller.Controller(view, model, viewupdateAnddelete);



            Application.Run(view);
        }
    }
}