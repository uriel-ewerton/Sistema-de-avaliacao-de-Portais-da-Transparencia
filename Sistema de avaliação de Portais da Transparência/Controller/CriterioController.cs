using SAPT.DAO;
using SAPT.DTO;
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
        public bool SalvarCriterio(string matriz, string dimensao, string pergunta, string classificacao)
        {
            CriterioDTO criterioDTO = new(matriz, dimensao, pergunta, classificacao);
            CriterioDAO criterioDAO = new();
            return criterioDAO.Salvar(criterioDTO);
        }

        public List<CriterioDTO> ListarCriterios()
        {
            CriterioDAO criterioDAO = new();
            List<CriterioDTO> criterios = criterioDAO.ListarTodos();  
            return criterios;
        }

        // Retorna lista de critérios que foram respondidos em determinada avaliação
        public List<CriterioDTO> ListarCriteriosJoinRespostas(AvaliacaoDTO avaliacao)
        {
            CriterioDAO criterioDAO = new();
            List<CriterioDTO> criterios = criterioDAO.ListarPorIDs(avaliacao);
            return criterios;
        }
    }
}
