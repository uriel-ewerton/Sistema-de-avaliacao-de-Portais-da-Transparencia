using SAPT.DAO;
using SAPT.DTO;
using SAPT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static SAPT.Model.Criterio;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAPT.Controller
{
    public class CriterioController
    {
        public int SalvarCriterio(string matriz, string dimensao, string pergunta, string classificacao)
        {
            CriterioDTO criterioDTO = new(matriz, dimensao, pergunta, classificacao);
            CriterioDAO criterioDAO = new();
            int retorno = criterioDAO.Salvar(criterioDTO);
            return retorno;

        }

        public List<CriterioDTO> ListarCriterios()
        {
            CriterioDAO criterioDAO = new();
            List<CriterioDTO> criterios = [];  
            return criterios;
        }

    }
}
