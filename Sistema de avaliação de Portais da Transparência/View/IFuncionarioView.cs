using SAPT.Controller;
using SAPT.DTO;
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
        void DisplayFuncionarios(List<FuncionarioDTO> funcionarios);
        void SetController(FuncionarioController controller);
    }
}