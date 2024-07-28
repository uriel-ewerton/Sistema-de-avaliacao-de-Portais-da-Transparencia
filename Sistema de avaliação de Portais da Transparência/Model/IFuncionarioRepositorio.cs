using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Model
{
    public interface IFuncionarioRepositorio
    {
        //Interface que funciona para dizer quais métodos serão implementados 
        //Diz quais métodos serão implementados mas não como serão implementados
        List<Funcionario> obterTodos(); 
        void Add(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(int id);
    }
}
