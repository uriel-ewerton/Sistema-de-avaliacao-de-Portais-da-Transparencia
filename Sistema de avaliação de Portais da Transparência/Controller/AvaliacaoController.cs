using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sistema_de_avaliação_de_Portais_da_Transparência.Model.Criterio;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Controller
{
    public class AvaliacaoController
    {
        public List<Avaliacao> Avaliacoes { get; private set; }

        public AvaliacaoController()
        {
            Avaliacoes = [];
        }

        public string ValidarAvaliacao(Panel pnlFormulario, List<string> selecoesIniciais)
        {

            Avaliacao avaliacaoAtual = new();
            string tituloAtual = "";
            string perguntaAtual = "";
            string respostaAtual = "";
            string linkAtual = "";
            string flagAtual = "";

            //extrai as informações dos controls no Panel
            foreach (Control control in pnlFormulario.Controls)
            {
                if (control is Label label && !string.IsNullOrEmpty(label.Text))
                {
                    // Verifica se é um título pelo nome do controle
                    if (control.Name.Equals("lblTitulo"))
                    {
                        tituloAtual = label.Text;
                        avaliacaoAtual.Criterios.Add(new Criterio { Titulo = tituloAtual });
                    }
                }
                else if (control is GroupBox grp)
                {
                    foreach (Control groupBoxControl in grp.Controls)
                    {
                        if (groupBoxControl is RadioButton rad && rad.Checked)
                        {
                            perguntaAtual = grp.Text;
                            respostaAtual = rad.Text;
                        }
                        else if (groupBoxControl is TextBox txt && txt.Visible)
                        {
                            linkAtual = txt.Text;
                        }
                        else if (groupBoxControl is Label flag)
                        {
                            flagAtual = flag.Text;
                        }
                    }

                    if (string.IsNullOrEmpty(respostaAtual) && flagAtual.Equals("Obrigatória"))
                    {
                        return "Pergunta obrigatória sem resposta";
                    }

                    if (!string.IsNullOrEmpty(respostaAtual) && string.IsNullOrEmpty(linkAtual)
                        && respostaAtual.Equals("Atende"))
                    {
                        return "Campo de link vazio";
                    }

                    // Adiciona a pergunta e a resposta na lista, junto com o título
                    if (!string.IsNullOrEmpty(perguntaAtual)
                            && !string.IsNullOrEmpty(respostaAtual)
                            && !string.IsNullOrEmpty(tituloAtual))
                    {
                        avaliacaoAtual.Criterios.Last().Perguntas.Add(
                        new Criterio.Pergunta
                        {
                            Texto = perguntaAtual,
                            Resposta = respostaAtual,
                            Flag = flagAtual,
                            Link = linkAtual
                        });
                        avaliacaoAtual.Municipio = selecoesIniciais[0];
                        avaliacaoAtual.Segmento = selecoesIniciais[1];
                        avaliacaoAtual.TipoAvaliacao = selecoesIniciais[2];
                        if(Avaliacoes.Count > 0)
                        {
                            avaliacaoAtual.Id = Avaliacoes.Last().Id + 1;
                        }
                        else if(Avaliacoes.Count == 0)
                        {
                            avaliacaoAtual.Id = 1;
                        }
                        
                    }
                    //else 
                    //{ 
                    //    return "Formulário vazio"; 
                    //};

                    respostaAtual = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }

            Avaliacoes.Add(avaliacaoAtual);
            return "Validado";

        }
        public string UltimaAvaliacaoString()
        {
            string ultimaAvaliacao = AvaliacaoToString(Avaliacoes.Last());
            return ultimaAvaliacao;
        }
        public string AvaliacaoToString(Avaliacao avaliacaoSelecionada)
        {
            List<string> avaliacaoString = [];
            try
            {
                Avaliacao avaliacao = avaliacaoSelecionada;
                avaliacaoString.Add($"Avaliação {avaliacao.Id}");
                avaliacaoString.Add($"Município: {avaliacao.Municipio}");
                avaliacaoString.Add($"Segmento: {avaliacao.Segmento}");
                avaliacaoString.Add($"Tipo de avaliação: {avaliacao.TipoAvaliacao}");
                avaliacaoString.Add($"Data da avaliação: {avaliacao.Timestamp}");

                foreach (Criterio criterio in avaliacao.Criterios)
                {
                    avaliacaoString.Add($"\n{criterio.Titulo}\n");
                    foreach (Criterio.Pergunta pergunta in criterio.Perguntas)
                    {
                        avaliacaoString.Add($"{pergunta.Texto}");
                        avaliacaoString.Add($"{pergunta.Resposta}");
                        if (!string.IsNullOrEmpty(pergunta.Link))
                        {
                            avaliacaoString.Add($"Link: {pergunta.Link}");
                        }

                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
            };
            string avaliacaoConcatenada = string.Join(Environment.NewLine, avaliacaoString);
            return avaliacaoConcatenada;
        }

        public void RemoverUltimaAvaliacao()
        {
            Avaliacoes.Remove(Avaliacoes.Last());
        }

    }

}
