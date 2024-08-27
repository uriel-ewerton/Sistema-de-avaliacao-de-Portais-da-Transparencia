using SAPT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPT.View;
using SAPT.DTO;
using SAPT.DAO;

namespace SAPT.Controller
{
    public class FuncionarioController
    {
        public List<FuncionarioDTO> carregarFuncionarios()
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            List<FuncionarioDTO> funcionarios = funcionario.ListarTodos();
            return funcionarios;
        }
        public int AddFuncionario(string login, string senha, int nivelAcesso)
        {
            //Criando um DTO funcionário com as informações recebidas 
            FuncionarioDTO funcionario = new FuncionarioDTO(login, senha, nivelAcesso);
            //Criando um funcionario DAO para persistir as informações
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            int retorno = funcionarioDAO.Salvar(funcionario);
            return retorno;
        }

        public int UpdateFuncionario(int id,string login, string senha, int nivelAcesso)
        {
            FuncionarioDTO funcionario = new FuncionarioDTO(id,login,senha,nivelAcesso);
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            int retorno = funcionarioDAO.Atualizar(funcionario);
            return retorno;
        }

        public int DeleteFuncionario(int id)
        {
            FuncionarioDAO funcionario = new FuncionarioDAO();
            int retorno = funcionario.Excluir(id);
            return retorno;
        }
    }
}
