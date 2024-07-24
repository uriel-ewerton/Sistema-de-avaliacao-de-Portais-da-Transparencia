using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public class Questao
    {
        public string Titulo { get; set; } = string.Empty;
        public List<Pergunta> Perguntas { get; set; } = [];
    }
}
