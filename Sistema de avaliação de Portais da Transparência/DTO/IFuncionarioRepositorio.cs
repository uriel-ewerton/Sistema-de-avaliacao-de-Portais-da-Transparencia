using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public interface IFuncionarioRepositorio
    {
        //Interface que funciona para dizer quais métodos serão implementados 
        //Diz quais métodos serão implementados mas não como serão implementados
        List<FuncionarioDTO> obterTodos();
        void Add(FuncionarioDTO funcionario);
        void Update(FuncionarioDTO funcionario);
        void Delete(int id);
    }
}
