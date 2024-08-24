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
                        else if (grpControl is TextBox txt && txt.Visible)
                        {
                            link = txt.Text;
                        }

                    }

                    if (resposta.Equals("true"))
                    {
                        return "Campo de link vazio";
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

        //public string UltimaAvaliacaoString()
        //{
        //    string ultimaAvaliacao = "";// AvaliacaoToString(Avaliacoes.Last());
        //    return ultimaAvaliacao;
        //}

        // provavelmente é um service
        //public string AvaliacaoToString(AvaliacaoDTO avaliacao)
        //{
        //    try
        //    {
        //        List<string> avaliacaoString = [];
        //        CriterioController criterioController = new();
        //        List<CriterioDTO> criterios = criterioController.ListarCriteriosJoinRespostas(avaliacao);
                
        //        // extrai as matrizes para filtrar quais conjuntos de critérios gerar
        //        List<string> matrizes = [];
        //        foreach (var c in criterios)
        //        {
        //            if (!matrizes.Contains(c.Matriz))
        //            {
        //                matrizes.Add(c.Matriz);
        //            }
        //        }
        //        // guarda as dimensões já lidas. (sera lido no segundo foreach abaixo)
        //        List<string> dimensoes = [];

        //        avaliacaoString.Add($"Avaliação {avaliacao.Id}");
        //        avaliacaoString.Add($"Município: {avaliacao.Municipio}");
        //        avaliacaoString.Add($"Segmento: {avaliacao.Segmento}");
        //        avaliacaoString.Add($"Tipo de avaliação: {avaliacao.TipoAvaliacao}");
        //        avaliacaoString.Add($"Data da avaliação: {avaliacao.DataAvaliacao}");

        //        foreach (CriterioDTO criterio in criterios)
        //        {
        //            avaliacaoString.Add($"\n{criterio.Matriz}\n");
        //            foreach (Criterio.Pergunta pergunta in criterio.Perguntas)
        //            {
        //                avaliacaoString.Add($"{pergunta.Texto}");
        //                avaliacaoString.Add($"{pergunta.Resposta}");
        //                if (!string.IsNullOrEmpty(pergunta.Link))
        //                {
        //                    avaliacaoString.Add($"Link: {pergunta.Link}");
        //                }

        //            }
        //        }
        //        string avaliacaoConcatenada = string.Join(Environment.NewLine, avaliacaoString);
        //        return avaliacaoConcatenada;
        //    }
        //    catch (Exception erro)
        //    {
        //        Console.WriteLine(erro);
        //    };
            
        //}

        public void RemoverUltimaAvaliacao()
        {
            //Avaliacoes.Remove(Avaliacoes.Last());
        }

    }

}
