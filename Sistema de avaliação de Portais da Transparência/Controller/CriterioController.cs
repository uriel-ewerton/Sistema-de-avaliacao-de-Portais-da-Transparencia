using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Controller
{
    public class CriterioController
    {
        public List<Criterio> Criterios { get; private set; }

        public CriterioController()
        {
            Criterios = [];
        }

        //adiciona manualmente os critérios- ajuda a formatação, ja que ainda não estamos utilizando arquivos
        public void CarregaCriterios()
        {
            //para cara critério adicionam-se as perguntas
            List<Criterio.Pergunta> infoPrioritarias =
            [
                new Criterio.Pergunta { Texto = "aaaaaaaaaaaaaaaaaaaaaaDivulga informações pormenorizadas das renúncias de receita, contendo, no mínimo, identificação dos beneficiários (nome e CNPJ),setor, espécie do benefício, produto (se aplicável), valor, contrapartida e/ou impacto obtido e/ou estimado (quando aplicável) e vigência?", Flag = "essencial" },
                new Criterio.Pergunta { Texto = "1.1 Possui sítio oficial próprio na internet?", Flag = "essencial" },
                new Criterio.Pergunta { Texto = "1.2 Possui portal da transparência próprio ou compartilhado na internet?", Flag = "essencial" },
                new Criterio.Pergunta { Texto = "1.3 O acesso ao portal transparência está visível na capa do site?", Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "1.4 O site e o portal de transparência contêm ferramenta de pesquisa de conteúdo que permita o acesso à informação?", Flag = "Obrigatória" }
            ];

            Criterios.Add(new Criterio { Titulo = "1. Informações Prioritárias", Perguntas = infoPrioritarias });

        }

        
        //demais métodos de edição de critérios, que serão utilizados no gerenciador
        //de formulários ....
    }
}
