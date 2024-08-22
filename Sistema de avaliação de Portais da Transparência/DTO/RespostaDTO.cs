using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class RespostaDTO(CriterioDTO criterioDTO, AvaliacaoDTO avaliacaoDTO, string resposta, string link)
    {
        private readonly CriterioDTO criterioDTO = criterioDTO ?? throw new ArgumentNullException(nameof(criterioDTO));
        private readonly AvaliacaoDTO avaliacaoDTO = avaliacaoDTO ?? throw new ArgumentNullException(nameof(avaliacaoDTO));
        private string Resposta { get; set; } = resposta ?? throw new ArgumentNullException(nameof(resposta));
        private string Link { get; set; } = link ?? throw new ArgumentNullException(nameof(link));
    }
}
