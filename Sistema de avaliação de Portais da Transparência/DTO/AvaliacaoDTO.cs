using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class AvaliacaoDTO
    {
        public int Id { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public string TipoAvaliacao { get; set; }
        public string Segmento { get; set; }
        public string Municipio { get; set; }
        public int IdUsuario { get; set; }

        // Lista de respostas associadas à avaliação
        public List<RespostaDTO> Respostas { get; set; } = [];

        public AvaliacaoDTO(int id, DateTime dataAvaliacao, string tipoAvaliacao, string segmento, string municipio, int idUsuario)
        {
            Id = id;
            DataAvaliacao = dataAvaliacao;
            TipoAvaliacao = tipoAvaliacao ?? throw new ArgumentNullException(nameof(tipoAvaliacao));
            Segmento = segmento ?? throw new ArgumentNullException(nameof(segmento));
            Municipio = municipio ?? throw new ArgumentNullException(nameof(municipio));
            IdUsuario = idUsuario;
        }

        public AvaliacaoDTO(DateTime dataAvaliacao, string tipoAvaliacao, string segmento, string municipio, int idUsuario, List<RespostaDTO> respostas)
        {
            DataAvaliacao = dataAvaliacao;
            TipoAvaliacao = tipoAvaliacao ?? throw new ArgumentNullException(nameof(tipoAvaliacao));
            Segmento = segmento ?? throw new ArgumentNullException(nameof(segmento));
            Municipio = municipio ?? throw new ArgumentNullException(nameof(municipio));
            IdUsuario = idUsuario;
            Respostas = respostas ?? throw new ArgumentNullException(nameof(respostas));
        }
    }
}
