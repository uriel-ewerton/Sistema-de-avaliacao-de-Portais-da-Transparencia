using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.Utilities
{
    public class ConexaoBD
    {
        private MySqlConnection con;
        public ConexaoBD()
        {
            string strconexao = "";
            strconexao = "server=localhost;userid=root;password=;database=banco_sapt";
            con = new MySqlConnection(strconexao);
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }
    }       
}
