using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static Sistema_de_avaliação_de_Portais_da_Transparência.Model.Criterio;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                //teste new Criterio.Pergunta { Texto = "aaaaaaaaaaaaaaaaaaaaaaDivulga informações pormenorizadas das renúncias de receita, contendo, no mínimo, identificação dos beneficiários (nome e CNPJ),setor, espécie do benefício, produto (se aplicável), valor, contrapartida e/ou impacto obtido e/ou estimado (quando aplicável) e vigência?", Flag = "essencial" },
                new Criterio.Pergunta { Texto = "1.1 Possui sítio oficial próprio na internet?", Flag = "Essencial" },
                new Criterio.Pergunta { Texto = "1.2 Possui portal da transparência próprio ou compartilhado na internet?", Flag = "Essencial" },
                new Criterio.Pergunta { Texto = "1.3 O acesso ao portal transparência está visível na capa do site?", Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "1.4 O site e o portal de transparência contêm ferramenta de pesquisa de conteúdo que permita o acesso à informação?", Flag = "Obrigatória" }
            ];

            Criterios.Add(new Criterio { Titulo = "1. Informações Prioritárias", Perguntas = infoPrioritarias });

            List<Criterio.Pergunta> infoInstitucionais =
            [
                new Criterio.Pergunta { Texto = "2.1 Divulga a sua estrutura organizacional?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.2 Divulga competências e/ou atribuições?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.3 Identifica o nome dos responsáveis pela gestão do Poder/Órgão?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.4 Divulga os endereços e telefones de Poder ou órgão e e-mails institucionais?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.5 Divulga o horário de atendimento?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.6 Divulga os atos normativos próprios?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.7 Divulga as perguntas e respostas mais frequentes relacionadas às atividades desenvolvidas pelo Poder/ Órgão?",
                Flag = "Obrigatória" },
                new Criterio.Pergunta { Texto = "2.8 Participa em redes sociais e apresenta, no seu sítio institucional, link de acesso ao seu perfil?",
                Flag = "Recomendada" },
                new Criterio.Pergunta { Texto = "2.9 Inclui botão do Radar da Transparência Pública no site institucional?",
                Flag = "Recomendada" },
                ];
            //Criterios.Add(new Criterio { Titulo = "2. Informações Institucionais", Perguntas = infoInstitucionais });
        }


        //demais métodos de edição de critérios, que serão utilizados no gerenciador
        //de formulários ....
    }
}
