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

        public void ValidarAvaliacao(Panel pnlFormulario)
        {
            List<string> respostas = [];
            string tituloAtual = "";
            string perguntaAtual = "";
            string respostaAtual = "";

            foreach (Control control in pnlFormulario.Controls)
            {
                if (control is Label label && !string.IsNullOrEmpty(label.Text))
                {
                    // Verifica se é um título pelo nome do controle
                    if (control.Name.Equals("lblTitulo"))
                    {
                        tituloAtual = label.Text;
                        respostas.Add($"\n{tituloAtual}\n");
                    }
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control groupBoxControl in groupBox.Controls)
                    {
                        if (groupBoxControl is RadioButton radioButton && radioButton.Checked)
                        {
                            respostaAtual = radioButton.Text;
                            perguntaAtual = groupBox.Text;
                        }
                        else if (groupBoxControl is TextBox textBox && textBox.Visible)
                        {
                            respostaAtual += $" (Link: {textBox.Text})";
                        }
                    }

                    // Adiciona a pergunta e a resposta na lista, junto com o título
                    if (!string.IsNullOrEmpty(perguntaAtual) && !string.IsNullOrEmpty(respostaAtual) && !string.IsNullOrEmpty(tituloAtual))
                    {
                        respostas.Add($"{perguntaAtual}: \n{respostaAtual}\n");
                    }
                    respostaAtual = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }
            string mensagem = string.Join(Environment.NewLine, respostas);
             MessageBox.Show(mensagem, "Respostas do Formulário");

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
