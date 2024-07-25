using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Controller
{
    public class AvaliacaoController
    {
        public Avaliacao AvaliacaoAtual { get; private set; }

        public AvaliacaoController()
        {
            AvaliacaoAtual = new Avaliacao();
        }
        /*
        
        public bool ValidarAvaliacao(out string mensagemErro)
        {
            mensagemErro = string.Empty;

            foreach (var pergunta in AvaliacaoAtual.Perguntas)
            {
                if (pergunta.Flag == "obrigatório" && string.IsNullOrEmpty(pergunta.Resposta))
                {
                    mensagemErro = $"A pergunta '{pergunta.Texto}' é obrigatória e precisa ser respondida.";
                    return false;
                }
                if (pergunta.Resposta == "Atende" && string.IsNullOrEmpty(pergunta.Link))
                {
                    mensagemErro = $"A pergunta '{pergunta.Texto}' requer um link.";
                    return false;
                }
            }

            return true;
        }
        */
    }

}
