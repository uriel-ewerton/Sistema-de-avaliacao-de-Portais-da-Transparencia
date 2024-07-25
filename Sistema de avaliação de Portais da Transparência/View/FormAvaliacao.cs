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
            _controller.CarregaCriterios();//leva o conteúdo às estruturas
           
            MontarFormulario();
        }

        private void MontarFormulario()
        {
            var criterios = _controller.Criterios;
            int y = 10;

            foreach (var questao in criterios)
            {
                Label tituloLabel = new Label
                {
                    Name = "tituloLabel",
                    Text = questao.Titulo,
                    //ALTERAR TAMANHO E FONTES
                    Location = new Point(10, y),
                    Width = 600
                };
                panel1.Controls.Add(tituloLabel);
                y += 30;

                // Adiciona Perguntas e Controles
                foreach (var pergunta in questao.Perguntas)
                {
                    Label perguntaLabel = new Label
                    {
                        Text = pergunta.Texto,
                        Location = new Point(10, y),
                        Width = 750,
                        Height = 50
                       
                    };
                    panel1.Controls.Add(perguntaLabel);
                    y += 35;


                    GroupBox opcoesGroupBox = new GroupBox
                    {
                        Location = new Point(10, y),
                        Width = 750,
                        Height = 50
                    };

                    TextBox linkTextBox = new TextBox
                    {
                        Location = new Point(250, 20),
                        Width = 300,
                        Visible = false 
                    };

                    RadioButton atendeRadioButton = new RadioButton
                    {
                        Text = "Atende",
                        Location = new Point(10, 20)
                    };
                    atendeRadioButton.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, linkTextBox);


                    RadioButton naoAtendeRadioButton = new RadioButton
                    {
                        Text = "Não Atende",
                        Location = new Point(140, 20)
                    };
                    naoAtendeRadioButton.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, linkTextBox);

                    opcoesGroupBox.Controls.Add(atendeRadioButton);
                    opcoesGroupBox.Controls.Add(naoAtendeRadioButton);
                    opcoesGroupBox.Controls.Add(linkTextBox);

                    panel1.Controls.Add(opcoesGroupBox);
                    y += 70; 
                }

            }
            Button enviar = new Button
            {
                Text = "Concluir Formulário",
                Location = new Point(300, y + 10),
                Width = 200,
                Height = 50
            };
            enviar.Click += EnviarButton_Click;
            panel1.Controls.Add (enviar);
        }

        private void OnRadioButtonCheckedChanged(object sender, EventArgs e, TextBox linkTextBox)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
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
            List<string> respostas = new List<string>();

            string tituloAtual = "";
            string perguntaAtual = "";
            string respostaAtual = "";

            foreach (Control control in panel1.Controls)
            {
                if (control is Label label && !string.IsNullOrEmpty(label.Text))
                {
                    // Verifica se é um título pelo nome do controle
                    if (control.Name.Equals("tituloLabel"))
                    {
                        tituloAtual = label.Text;
                        respostas.Add($"\n{tituloAtual}\n");
                    }
                    else
                    {
                        perguntaAtual = label.Text;
                    }
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (Control groupBoxControl in groupBox.Controls)
                    {
                        if (groupBoxControl is RadioButton radioButton && radioButton.Checked)
                        {
                            respostaAtual = radioButton.Text;
                        }
                        else if (groupBoxControl is TextBox textBox && textBox.Visible)
                        {
                            respostaAtual += $" (Link: {textBox.Text})";
                        }
                    }

                    // Adiciona a pergunta e a resposta na lista, junto com o título
                    respostas.Add($"\n{perguntaAtual}: {respostaAtual}");
                    respostaAtual = ""; // Limpa a resposta atual para a próxima pergunta
                }
            }

            // Exibir dados na MessageBox
            string mensagem = string.Join(Environment.NewLine, respostas);
            MessageBox.Show(mensagem, "Respostas do Formulário");
        }

    }
}
