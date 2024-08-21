using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DAO
{
    public interface IFuncionarioRepositorio
    {
        //Interface que funciona para dizer quais métodos serão implementados 
        //Diz quais métodos serão implementados mas não como serão implementados
        List<FuncionarioDAO> obterTodos(); 
        void Add(FuncionarioDAO funcionario);
        void Update(FuncionarioDAO funcionario);
        void Delete(int id);
    }
}
