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
        public string Municipio { get; set; } = string.Empty;
        public string Segmento { get; set; } = string.Empty;
        public string TipoAvaliacao { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public List<CriterioDTO> Criterios { get; set; } = [];
    }
}
