using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class RespostaDTO(CriterioDTO criterioDTO, AvaliacaoDTO avaliacaoDTO, bool resposta, string link)
    {
        //Chaves primárias
        public readonly CriterioDTO criterioDTO = criterioDTO ?? throw new ArgumentNullException(nameof(criterioDTO));
        public readonly AvaliacaoDTO avaliacaoDTO = avaliacaoDTO ?? throw new ArgumentNullException(nameof(avaliacaoDTO));

        public bool Resposta { get; set; } = resposta;
        public string Link { get; set; } = link ?? throw new ArgumentNullException(nameof(link));
    }
}
