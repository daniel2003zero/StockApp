using StockApp.Business.Interfaces.Database;
using StockApp.WindowsForms._inicializar;

namespace StockApp.WindowsForms
{
    internal static class Program

    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                var banco = new InicializarDatabase(); 
                banco.Init();
            }
            catch (Exception)
            {

                throw;
            }



            Application.Run(new Form());
        }
    }
}