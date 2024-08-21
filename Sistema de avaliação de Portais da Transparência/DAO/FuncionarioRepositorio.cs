using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DAO
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private List<FuncionarioDAO> funcionarios = new List<FuncionarioDAO> ();

        public List<FuncionarioDAO> obterTodos()
        {
            return funcionarios;
        }

        public void Add(FuncionarioDAO funcionario)
        {
            //O trecho de código abaixo garante que todo funcionário terá um identificador(ID) único
            funcionario.Id = funcionarios.Count > 0 ? funcionarios.Max(f => f.Id) + 1 : 1;
            funcionarios.Add(funcionario);
        }

        public void Update(FuncionarioDAO funcionario)
        {
            //A linha abaixo verifica se o funcionário existe na lista de funcionários
            var existingFuncionario = funcionarios.FirstOrDefault(f => f.Id == funcionario.Id);
            //Se o funcionário for encontrado através de "firstOrDefault", suas informações são atualizadas
            if (existingFuncionario != null)
            {
                existingFuncionario.Nome = funcionario.Nome;
                existingFuncionario.Cargo = funcionario.Cargo;
                existingFuncionario.Salario = funcionario.Salario;
            }
        }

        public void Delete(int id)
        {
            var funcionario = funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario != null)
                funcionarios.Remove(funcionario);
        }

    }
}
