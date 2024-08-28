using MySqlConnector;
using SAPT.DTO;
using SAPT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.Utilities.Log
{
    public class LogDAO
    {
        private MySqlConnection con;
        private string? comandoSql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public LogDAO()
        {
            ConexaoBD conexaoBd = new();
            con = conexaoBd.RetornaConexao();
        }

        public bool Salvar(LogDTO LogDTO)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                comandoSql = "insert into login_log (entrada, saida, login, Usuarios_id) "
                    + "values (@entrada, @saida, @login, @Usuarios_id)";

                envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@entrada", LogDTO.Entrada);
                envelope.Parameters.AddWithValue("@saida", LogDTO.Saida);
                envelope.Parameters.AddWithValue("@login",LogDTO.Login);
                envelope.Parameters.AddWithValue("@Usuarios_id", LogDTO.Usuario);
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

        public bool AtualizarUltimo(int usuario_id)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                // atualiza ultimo log com a hora de saída
                comandoSql = "UPDATE login_log SET saida = @saida WHERE Usuarios_id = @Usuarios_id";
                envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@Usuarios_id", usuario_id);
                envelope.Parameters.AddWithValue("@saida", DateTime.Now);
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
    }
}
