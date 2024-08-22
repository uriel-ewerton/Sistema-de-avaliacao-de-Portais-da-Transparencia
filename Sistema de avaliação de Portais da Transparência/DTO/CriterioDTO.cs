using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class CriterioDTO(string matriz, string dimensao, string pergunta, string classificacao)
    {
        public string Matriz { get; set; } = matriz ?? throw new ArgumentNullException(nameof(matriz));
        public string Dimensao { get; set; } = dimensao;
        public string Pergunta { get; set; } = pergunta ?? throw new ArgumentNullException(nameof(pergunta));
        public string Classificacao { get; set; } = classificacao ?? throw new ArgumentNullException(nameof(classificacao));
    }
}
