using MySqlConnector;
using SAPT.DTO;
using SAPT.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DAO
{
    public class TesteDAO
    {
        private MySqlConnection con;
        private string? comandosql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public TesteDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public List<TesteDTO> ListarTodos()
        {
            List<TesteDTO> listateste = new List<TesteDTO>();

            con.Open();
            comandosql = "select * from usuarios";
            envelope = new MySqlCommand();
            envelope.CommandText = comandosql;
            envelope.Connection = con;
            cursor = envelope.ExecuteReader();
            while (cursor.Read())
            {
                TesteDTO testeDTO = new TesteDTO(cursor.GetInt32("id"), cursor.GetString("login"), cursor.GetString("senha"), cursor.GetInt32("nivel_acesso"));
                listateste.Add(testeDTO);
            }
            con.Close();
            return listateste;
        }
    }
}
