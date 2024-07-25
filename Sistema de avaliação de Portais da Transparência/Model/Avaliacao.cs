using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Model
{
    public class Avaliacao
    {
        public string Municipio { get; set; } = string.Empty;
        public string Segmento { get; set; } = string.Empty;
        public string TipoAvaliacao { get; set; } = string.Empty;
        public List<Criterio> Criterios { get; set; } = new List<Criterio>();
    }
}
