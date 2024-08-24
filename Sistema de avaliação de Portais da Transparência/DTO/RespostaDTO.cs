using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class RespostaDTO
    {
        // Chaves primárias
        //public readonly CriterioDTO criterioDTO;
        //public readonly AvaliacaoDTO avaliacaoDTO;
        public int CriterioId { get; set; }
        public int AvaliacaoId { get; set; }
        public bool Resposta { get; set; }
        public string Link { get; set; }

        public RespostaDTO(int criterioId, int avaliacaoId, bool resposta, string link)
        {
            CriterioId = criterioId;
            AvaliacaoId = avaliacaoId;
            Resposta = resposta;
            Link = link;
        }

        public RespostaDTO(int criterioId, bool resposta, string link)
        {
            CriterioId = criterioId;
            Resposta = resposta;
            Link = link;
        }


        //public RespostaDTO(CriterioDTO criterioDTO, AvaliacaoDTO avaliacaoDTO, bool resposta, string link)
        //{
        //    this.criterioDTO = criterioDTO ?? throw new ArgumentNullException(nameof(criterioDTO));
        //    this.avaliacaoDTO = avaliacaoDTO ?? throw new ArgumentNullException(nameof(avaliacaoDTO));
        //    Resposta = resposta;
        //    Link = link;
        //}

    }
}
