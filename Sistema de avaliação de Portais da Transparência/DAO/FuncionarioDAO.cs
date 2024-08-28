using MySqlConnector;
using SAPT.DTO;
using SAPT.Utilities;
using System;
using System.Collections.Generic;

namespace SAPT.DAO
{
    public class FuncionarioDAO
    {
        private readonly MySqlConnection con;

        public FuncionarioDAO()
        {
            ConexaoBD conexaoBd = new();
            con = conexaoBd.RetornaConexao();
        }

        public int Salvar(FuncionarioDTO funcionarioDTO)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                string comandoSql = "INSERT INTO usuarios (login, senha, nivel_acesso) VALUES " +
                "(@login, @senha, @nivel_acesso)";

                using MySqlCommand envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@login", funcionarioDTO.Login);
                envelope.Parameters.AddWithValue("@senha", funcionarioDTO.Senha);
                envelope.Parameters.AddWithValue("@nivel_acesso", funcionarioDTO.Nivel_Acesso);

                int resultado = envelope.ExecuteNonQuery();
                tran.Commit();
                return resultado;
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

        public List<FuncionarioDTO> ListarTodos()
        {
            List<FuncionarioDTO> listaFuncionarios = new();
            con.Open();
            string comandoSql = "SELECT * FROM usuarios";
            using MySqlCommand envelope = new MySqlCommand(comandoSql, con);
            using MySqlDataReader cursor = envelope.ExecuteReader();
            try
            {
                    while (cursor.Read())
                    {
                        FuncionarioDTO funcionarioDTO = new(
                            cursor.GetInt32("id"),
                            cursor.GetString("login"),
                            cursor.GetString("senha"),
                            cursor.GetInt32("nivel_acesso"));
                        listaFuncionarios.Add(funcionarioDTO);
                    }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return listaFuncionarios;
        }

        public FuncionarioDTO PorId(int id)
        {
            FuncionarioDTO funcionario = new();
            con.Open();
            string comandoSql = "SELECT * FROM usuarios WHERE id = @id";
            using MySqlCommand envelope = new(comandoSql, con);
            envelope.Parameters.AddWithValue("@id", id);
            using MySqlDataReader cursor = envelope.ExecuteReader();
            if (cursor.Read())
            {
                funcionario = new(
                    cursor.GetInt32("id"),
                    cursor.GetString("login"),
                    cursor.GetString("senha"),
                    cursor.GetInt32("nivel_acesso"));
            }
            con.Close();
            return funcionario;

        }
        public int Atualizar(FuncionarioDTO funcionarioDTO)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                string comandoSql = "UPDATE usuarios SET login = @login, senha = @senha," +
                " nivel_acesso = @nivel_acesso WHERE id = @id";
                using MySqlCommand envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@id", funcionarioDTO.Id);
                envelope.Parameters.AddWithValue("@login", funcionarioDTO.Login);
                envelope.Parameters.AddWithValue("@senha", funcionarioDTO.Senha);
                envelope.Parameters.AddWithValue("@nivel_acesso", funcionarioDTO.Nivel_Acesso);

                int resultado = envelope.ExecuteNonQuery();
                tran.Commit();
                return resultado;
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

        public int Excluir(int id)
        {
            con.Open();
            using MySqlTransaction tran = con.BeginTransaction();
            try
            {
                string comandoSql = "DELETE FROM usuarios WHERE id = @id";
                using MySqlCommand envelope = new MySqlCommand(comandoSql, con, tran);
                envelope.Parameters.AddWithValue("@id", id);

                int resultado = envelope.ExecuteNonQuery();
                tran.Commit();
                return resultado;
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
