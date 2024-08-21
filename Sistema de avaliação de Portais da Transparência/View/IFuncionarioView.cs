using SAPT.Controller;
using SAPT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.View
{
    public interface IFuncionarioView
    {
            void DisplayFuncionarios(List<Funcionario> funcionarios);
            void SetController(FuncionarioController controller);
    }
}
