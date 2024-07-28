using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.View
{
    public interface IFuncionarioView
    {
            void DisplayFuncionarios(List<Funcionario> funcionarios);
            void SetController(FuncionarioController controller);
    }
}
