using SAPT.DAO;
using SAPT.DTO;

namespace SAPT.Controller
{
    public class AvaliacaoController
    {
        // Mantém uma cópia dos dados antes de serem enviados ao banco
        public DTO.AvaliacaoDTO? AvaliacaoCache { get; set; }

        // Usa as informações contidas nos controles para gerar uma instancia de avaliação
        public string ValidarAvaliacao(Panel pnlFormulario, List<string> selecoesIniciais)
        {
            DTO.AvaliacaoDTO avaliacao = new();
            string resposta = "";
            string link = "";

            //extrai as informações dos controls no Panel
            foreach (Control control in pnlFormulario.Controls)
            {
                if (control is GroupBox grp)
                {
                    foreach (Control grpControl in grp.Controls)
                    {
                        // guarda a resposta do radionbutton
                        if (grpControl is RadioButton rad && rad.Checked)
                        {
                            if (rad.Checked && rad.Text.Equals("Atende"))
                            {
                                resposta = "true";
                            }
                            else if (rad.Checked && !rad.Text.Equals("Atende"))
                            {
                                resposta = "false";
                            }
                        }
                        // guarda o texto do link
                        else if (grpControl is TextBox txt)
                        {
                            link = txt.Text;
                        }

                    }

                    if (control.Controls[2] is TextBox box && resposta.Equals("true"))
                    {
                        if (string.IsNullOrEmpty(box.Text)){
                            return "Campo de link obrigatório vazio";
                        }
                    }

                    // Adiciona a pergunta e a resposta na lista, junto com o título
                    if (!string.IsNullOrEmpty(resposta))
                    {
                        int id = Convert.ToInt32(grp.Tag); // id passado dentro do FormAvaliacao
                        avaliacao.Respostas.Add(
                            new RespostaDTO(id, bool.Parse(resposta), link));
                        avaliacao.Municipio = selecoesIniciais[0];
                        avaliacao.Segmento = selecoesIniciais[1];
                        avaliacao.TipoAvaliacao = selecoesIniciais[2];
                    }

                    resposta = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }
            avaliacao.DataAvaliacao = DateTime.Now;
            AvaliacaoCache = avaliacao;

            return "Validado";

        }

        // provavelmente é um service
        // Monta uma string com cabeçalho, perguntas e respostas da ultima avaliação validada
        public string AvaliacaoToString()
        {
            try
            {
                // string onde serão colocados os dados da avaliação
                List<string> avaliacaoString = [];

                // recupera os criterios respondidos na avaliação
                CriterioController criterioController = new();
                if (AvaliacaoCache == null)
                {
                    return "Erro: avaliação vazia.";
                }
                List<CriterioDTO> criterios = criterioController.ListarCriteriosJoinRespostas(AvaliacaoCache);

                // Usa HashSet para verificar presença de matrizes e dimensões de maneira mais eficiente
                HashSet<string> matrizes = [];
                HashSet<string> dimensoes = [];

                // prepara o cabeçalho
                if(AvaliacaoCache.Id == 0)// Em Avaliações novas o id costuma ser 0 pois o auto-increment ainda nao foi retornado
                {
                    avaliacaoString.Add($"Avaliação Nova");
                }
                else
                {
                    avaliacaoString.Add($"Avaliação {AvaliacaoCache.Id}");
                }
                avaliacaoString.Add($"Município: {AvaliacaoCache.Municipio}");
                avaliacaoString.Add($"Segmento: {AvaliacaoCache.Segmento}");
                avaliacaoString.Add($"Tipo de avaliação: {AvaliacaoCache.TipoAvaliacao}");
                avaliacaoString.Add($"Data da avaliação: {AvaliacaoCache.DataAvaliacao}");
                int index = 0;

                // prepara perguntas e respostas
                foreach (CriterioDTO criterio in criterios)
                {
                    // Verifica se a matriz já foi adicionada
                    if (matrizes.Add(criterio.Matriz))
                    {
                        avaliacaoString.Add($"\n{criterio.Matriz}\n");
                    }

                    // Adiciona a dimensão, caso haja, e evita que o mesmo tópico se repita
                    if (!string.IsNullOrEmpty(criterio.Dimensao) && dimensoes.Add(criterio.Dimensao))
                    {
                        avaliacaoString.Add($"{criterio.Dimensao}");
                    }
                    // Add pergunta
                    avaliacaoString.Add($"{criterio.Pergunta}");

                    // Add resposta, que existe no DTO como bool
                    if (AvaliacaoCache.Respostas[index].Resposta)
                    {
                        avaliacaoString.Add($"Atende");
                    }
                    else
                    {
                        avaliacaoString.Add($"Não atende");
                    }

                    // Add link, se houver
                    if (!string.IsNullOrEmpty(AvaliacaoCache.Respostas[index].Link))
                    {
                        avaliacaoString.Add($"Link ou justificativa: {AvaliacaoCache.Respostas[index].Link}\n");
                    }

                    // Add espaçador caso o link esteja vazio
                    else
                    {
                        avaliacaoString.Add($"\n"); 
                    }
                    index++;
                }

                string avaliacaoConcatenada = string.Join(Environment.NewLine, avaliacaoString);
                return avaliacaoConcatenada;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                return "";
            };
        }

        public string AvaliacaoToStringPorId(int id)
        {
            AvaliacaoDAO avaliacaoDAO = new();
            AvaliacaoCache = avaliacaoDAO.BuscarPorId(id);
            string avaliacao = AvaliacaoToString();
            AvaliacaoCache = null;
            return avaliacao;
        }
        // Retorna lista com todas as avaliações registradas no banco. 
        // Obs: Somente propriedades de AvaliacaoDTO
        public List<AvaliacaoDTO> ListarAvaliacoes()
        {
            AvaliacaoDAO avaliacaoDAO = new();
            List<AvaliacaoDTO> avaliacoes = avaliacaoDAO.ListarTodas();
            return avaliacoes;
        }

        public bool SalvarAvaliacao()
        {
            AvaliacaoDAO avaliacaoDAO = new();
            if (AvaliacaoCache != null)
            {
                return avaliacaoDAO.Salvar(AvaliacaoCache);
            }
            return false;

        }
        public void LimparCacheAvaliacao()
        {
            AvaliacaoCache = null;
        }

    }

}
