using Microsoft.VisualBasic;
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
        public string Usuario { get; set; } = string.Empty; //talvez utilizar o model usuário. não sei se piora muito a coesão.
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public List<Criterio> Criterios { get; set; } = [];
        //public Dictionary<Criterio, string> Respostas { get; set; } = [];

        //usuário - data - respostas
        //listar avaliações
        //view bloco com atributos              botão para mostrar messageBox com perguntas e respostas

        /*  
         criterios
            criterio
                titulo
                perguntas
                    pergunta
                        texto
                        flag
                        resposta
                respostas
                    resposta
                         texto
         
         */
    }
}
