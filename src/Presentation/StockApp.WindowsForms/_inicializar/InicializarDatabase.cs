using StockApp.Business.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.WindowsForms._inicializar
{
    internal class InicializarDatabase
    {
        private readonly IDataBaseService _databaseService;

        public InicializarDatabase()
        {
            _databaseService = new DataBaseService();
        }

        public InicializarDatabase(IDataBaseService databaseService)
        {
            _databaseService = databaseService;
        }

         internal void Init() 
        {
            _databaseService.CriarBanco();        
        }
    }

}
