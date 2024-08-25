using MySqlConnector;
using SAPT.DTO;
using SAPT.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SAPT.DAO
{
    public class AvaliacaoDAO
    {
        private readonly MySqlConnection con;
        private string? comandoSql;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;

        public AvaliacaoDAO()
        {
            ConexaoBD conexaoBD = new();
            con = conexaoBD.RetornaConexao();
        }

        public bool Salvar(AvaliacaoDTO avaliacaoDTO)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                // Salva avaliação
                comandoSql = "insert into Avaliacoes (data_avaliacao, tipo_avaliacao, segmento, municipio, Usuarios_id) "
                    + "values (@data_avaliacao, @tipo_avaliacao, @segmento, @municipio, @Usuarios_id)";
                envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@data_avaliacao", avaliacaoDTO.DataAvaliacao);
                envelope.Parameters.AddWithValue("@tipo_avaliacao", avaliacaoDTO.TipoAvaliacao);
                envelope.Parameters.AddWithValue("@segmento", avaliacaoDTO.Segmento);
                envelope.Parameters.AddWithValue("@municipio", avaliacaoDTO.Municipio);
                envelope.Parameters.AddWithValue("@Usuarios_id", 1); //alterar quando o crud de usuário estiver pronto
                envelope.ExecuteNonQuery();

                // Retorna id (auto-increment) da avaliação
                comandoSql = "SELECT LAST_INSERT_ID();";
                envelope = new MySqlCommand(comandoSql, con, tran);
                avaliacaoDTO.Id = Convert.ToInt32(envelope.ExecuteScalar());

                // Salva respostas
                comandoSql = "insert into Respostas (Avaliacoes_id, resposta, link, Criterios_id) "
                    + "values (@Avaliacoes_id, @resposta, @link, @Criterios_id)";
                envelope = new MySqlCommand(comandoSql, con, tran);

                // Adiciona parâmetros com nomes específicos para reuso no loop
                envelope.Parameters.Add("@Avaliacoes_id", MySqlDbType.Int32);
                envelope.Parameters.Add("@resposta", MySqlDbType.Bool);
                envelope.Parameters.Add("@link", MySqlDbType.VarChar, 255);
                envelope.Parameters.Add("@Criterios_id", MySqlDbType.Int32);

                envelope.Prepare();

                foreach (RespostaDTO respostaDTO in avaliacaoDTO.Respostas)
                {
                    envelope.Parameters["@Avaliacoes_id"].Value = avaliacaoDTO.Id;
                    envelope.Parameters["@resposta"].Value = respostaDTO.Resposta;
                    envelope.Parameters["@link"].Value = respostaDTO.Link;
                    envelope.Parameters["@Criterios_id"].Value = respostaDTO.CriterioId;

                    envelope.ExecuteNonQuery();
                }
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

        public List<AvaliacaoDTO> ListarTodas()
        {
            List<AvaliacaoDTO> listaAvaliacoes = [];
            con.Open();
            comandoSql = "select * from Avaliacoes";
            envelope = new MySqlCommand(comandoSql, con);
            cursor = envelope.ExecuteReader();
            while (cursor.Read())
            {
                AvaliacaoDTO avaliacao = new(
                    cursor.GetInt32("id"), 
                    cursor.GetDateTime("data_avaliacao"),
                    cursor.GetString("tipo_avaliacao"),
                    cursor.GetString("segmento"),
                    cursor.GetString("municipio"),
                    cursor.GetInt32("Usuarios_id")
                    );
                listaAvaliacoes.Add(avaliacao);
            }
            con.Close();
            return listaAvaliacoes;
        }

        public AvaliacaoDTO BuscarPorId(int id)
        {
            AvaliacaoDTO avaliacao = new();
            con.Open();
            comandoSql = "select * from Avaliacoes where id = @id";
            envelope = new MySqlCommand(comandoSql, con);
            envelope.Parameters.AddWithValue("@id", id);

            cursor = envelope.ExecuteReader();
            while (cursor.Read())
            {
                avaliacao = new(
                    cursor.GetInt32("id"),
                    cursor.GetDateTime("data_avaliacao"),
                    cursor.GetString("tipo_avaliacao"),
                    cursor.GetString("segmento"),
                    cursor.GetString("municipio"),
                    cursor.GetInt32("Usuarios_id")
                    );
            }
            con.Close();
            return avaliacao;

        }
    }
}
