using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionando namespacing de conexao banco de dados
using System.Data;
using System.Data.SqlClient;

namespace TrelloAPI
{
    public class AcessaDadosSQLServer
    {
        public SqlConnection CriarConexaoBanco()
        {
            //parametros para conexao com o banco de dados
            string stringConexao = "Data Source=DESKTOP-ORTRKJA;Initial Catalog=TrelloAPI;User ID=sa;Password=506829;Connect Timeout=10";

            SqlConnection connection = new SqlConnection(stringConexao);

            return connection;
        }
    }
}
