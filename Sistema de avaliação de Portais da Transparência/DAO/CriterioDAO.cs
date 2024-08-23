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
    public class CriterioDAO
    {
        private MySqlConnection con;
        private string? comandoSql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public CriterioDAO()
        {
            ConexaoBD conexaoBd = new ConexaoBD();
            con = conexaoBd.RetornaConexao();
        }

        public bool Salvar(CriterioDTO criterioDTO)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                comandoSql = "insert into criterios (matriz, dimensao, pergunta, classificacao) "
                    + "values (@matriz, @dimensao, @pergunta, @classificacao)";

                envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@matriz", criterioDTO.Matriz);
                envelope.Parameters.AddWithValue("@dimensao", criterioDTO.Dimensao);
                envelope.Parameters.AddWithValue("@pergunta", criterioDTO.Pergunta);
                envelope.Parameters.AddWithValue("@classificacao", criterioDTO.Classificacao);
                envelope.ExecuteNonQuery();

                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
            finally
            {
                con.Close();
            }
            
        }

        public List<CriterioDTO> ListarTodos()
        {
            List<CriterioDTO> listaCriterios = new List<CriterioDTO>();
            con.Open();
            comandoSql = "select * from criterios";
            envelope = new MySqlCommand( comandoSql, con);
            cursor = envelope.ExecuteReader();
            while (cursor.Read())
            {
                CriterioDTO criterioDTO = new(
                    cursor.GetInt32("id"),
                    cursor.GetString("matriz"),
                    cursor.GetString("dimensao"),
                    cursor.GetString("pergunta"),
                    cursor.GetString("classificacao"));
                listaCriterios.Add(criterioDTO);
            }
            con.Close();
            return listaCriterios;
        }
    }
}
