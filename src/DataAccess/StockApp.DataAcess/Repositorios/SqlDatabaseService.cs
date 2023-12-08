using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Repositorios
{
    internal class SqlDatabaseService
    {
            static string ConexaoSemBanco => @"server=localhost; Integrated Security=true; User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
            static string ConexaoComBanco => @"Data Source=.\SQLEXPRESS;Initial Catalog=STOCKELETRO;User ID=sa;Password=sql2022; Trusted_Connection=False; TrustServerCertificate=True";
        
    }

}

