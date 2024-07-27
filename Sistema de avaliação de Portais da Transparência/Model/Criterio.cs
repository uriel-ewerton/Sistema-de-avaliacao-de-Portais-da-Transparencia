﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Model
{
    public class Criterio
    {
        public class Pergunta
        {
            public string Texto { get; set; } = string.Empty;
            public string Flag { get; set; } = string.Empty;
            public string Resposta {  get; set; } = string.Empty;//para uso no formulário
            public string Link { get; set; } = string.Empty;
            public override string ToString()
            {
                return $"{{{nameof(Texto)}={Texto}, {nameof(Flag)}={Flag}, {nameof(Resposta)}={Resposta}}}";
            }
        }

        public string Titulo { get; set; } = string.Empty;
        public List<Pergunta> Perguntas { get; set; } = [];

        public override string ToString()
        {
            return $"{{{nameof(Titulo)}={Titulo}, {nameof(Perguntas)}={Perguntas}}}";
        }

        /*
         * label
         * grp
         * rad
         * rad
         * txt
         * flag
         * 
         * 
         * Estrutura geral
         lista de Criterios
            criterio1
                titulo
                lista de perguntas
                    pergunta1
                        texto 
                        flag
                    pergunta2
                        texto 
                        flag

            criterio2
                titulo
                lista de perguntas
                   pergunta1
                        texto 
                        flag
                    pergunta2
                        texto 
                        flag
         */
    }
}
