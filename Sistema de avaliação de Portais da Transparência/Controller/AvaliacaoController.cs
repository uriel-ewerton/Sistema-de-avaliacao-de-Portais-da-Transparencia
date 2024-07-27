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
        public List<Avaliacao> Avaliacoes { get; private set; }

        public AvaliacaoController()
        {
            Avaliacoes = [];
        }

        public string ValidarAvaliacao(Panel pnlFormulario)
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
                        //respostas.Add($"\n{tituloAtual}\n");
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
                        else if(groupBoxControl is Label flag) {
                            flagAtual = flag.Text;  
                        }
                    }

                    if (string.IsNullOrEmpty(respostaAtual) && flagAtual.Equals("Obrigatória"))
                    {
                        return "Pergunta obrigatória sem resposta";
                    }

                    if (!string.IsNullOrEmpty(respostaAtual) && string.IsNullOrEmpty(linkAtual))
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
                    }
                    //else 
                    //{ 
                    //    return "Formulário vazio"; 
                    //};

                    respostaAtual = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }

            //avaliacaoAtual.Criterios.RemoveAll(List<Pergunta> perguntaAtual = [])
            //avaliacaoAtual.Criterios.Reverse();
            Avaliacoes.Add(avaliacaoAtual);
            return "Validado";

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
