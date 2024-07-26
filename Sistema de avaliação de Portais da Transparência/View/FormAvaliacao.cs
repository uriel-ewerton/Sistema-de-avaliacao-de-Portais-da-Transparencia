using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class FormAvaliacao : Form
    {
        private readonly CriterioController _controller;

        public FormAvaliacao(CriterioController controller)
        {
            InitializeComponent();
            _controller = controller;
            //_controller.CarregaCriterios();//leva o conteúdo às estruturas
           
            MontarFormulario();
        }

        private void MontarFormulario()
        {
            var criterios = _controller.Criterios;
            int y = 10;

            foreach (var criterio in criterios)
            {
                Label lblTitulo = new()
                {
                    Name = "lblTitulo",
                    Text = criterio.Titulo,
                    //ALTERAR TAMANHO E FONTES
                    Location = new Point(10, y),
                    Width = 600
                };
                pnlFormulario.Controls.Add(lblTitulo);
                y += 30;

                // Adiciona Perguntas e Controles
                foreach (var pergunta in criterio.Perguntas)
                {
                    GroupBox grpPergunta = new()
                    {
                        Text = pergunta.Texto,
                        Location = new Point(10, y),
                        Width = 750,
                        Height = 55
                    };

                    TextBox txtLink = new()
                    {
                        Location = new Point(250, 20),
                        Width = 300,
                        Visible = false ,
                        PlaceholderText = "Insira o Link de Justificativa. (Obrigatório)"
                    };
                    
                    RadioButton radAtende = new()
                    {
                        Text = "Atende",
                        Location = new Point(10, 20)
                    };
                    radAtende.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, txtLink);

                    RadioButton radNaoAtende = new()
                    {
                        Text = "Não Atende",
                        Location = new Point(140, 20)
                    };
                    radNaoAtende.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, txtLink);

                    //regula os tamanhos caso o critério exceda 2 linhas
                    if (pergunta.Texto.Length >= 250)
                    {
                        grpPergunta.Height = 75;
                        radAtende.Location = new Point(10, 45);
                        radNaoAtende.Location = new Point(140, 45);
                        txtLink.Location = new Point(250, 45);
                        y += 10;
                    }
                    grpPergunta.Controls.Add(radAtende);
                    grpPergunta.Controls.Add(radNaoAtende);
                    grpPergunta.Controls.Add(txtLink);

                    pnlFormulario.Controls.Add(grpPergunta);
                    y += 70; 
                }

            }
            Button btnEnviar = new()
            {
                Text = "Concluir Formulário",
                Location = new Point(270, y + 10),
                Width = 200,
                Height = 50
            };
            btnEnviar.Click += EnviarButton_Click;
            pnlFormulario.Controls.Add (btnEnviar);
        }

        private static void OnRadioButtonCheckedChanged(object sender, EventArgs e, TextBox linkTextBox)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                linkTextBox.Visible = radioButton.Text == "Atende";
            }
        }

        /*ainda não implementa o model+controller Avaliação. A saída ocorre somente
            no messageBox
         */
        private void EnviarButton_Click(object sender, EventArgs e)
        {
            // Coleta os dados do formulário
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
                        respostas.Add($"\n{perguntaAtual}: {respostaAtual}");
                    }
                    respostaAtual = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }

            // Exibir dados na MessageBox
            string mensagem = string.Join(Environment.NewLine, respostas);
            MessageBox.Show(mensagem, "Respostas do Formulário");
        }

    }
}
