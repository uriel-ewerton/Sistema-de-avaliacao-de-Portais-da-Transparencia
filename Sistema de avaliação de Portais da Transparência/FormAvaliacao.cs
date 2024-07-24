using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class FormAvaliacao : Form
    {
        public FormAvaliacao()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            var questoes = CarregarCriterios();
            int y = 10;

            foreach (var questao in questoes)
            {
                // Adicionar Título
                Label tituloLabel = new Label
                {
                    Text = questao.Titulo,
                    //alterar tamanho e fontes
                    Location = new Point(10, y),
                    Width = 600
                };
                panel1.Controls.Add(tituloLabel);
                y += 30;

                // Adicionar Perguntas e Controles
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
                        Visible = false // Inicialmente invisível
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
                    y += 70; // Incrementa para a próxima pergunta
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

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            // Coletar dados do formulário
            List<string> respostas = new List<string>();

            foreach (Control control in panel1.Controls)
            {

                if (control is GroupBox groupBox)
                {
                    string pergunta = "";
                    string resposta = "";

                    foreach (Control groupBoxControl in groupBox.Controls)
                    {
                        if (groupBoxControl is RadioButton radioButton && radioButton.Checked)
                        {
                            resposta = radioButton.Text;
                        }
                        else if (groupBoxControl is TextBox textBox && textBox.Visible)
                        {
                            resposta += $" (Link: {textBox.Text})";
                        }
                    }

                    // Adiciona a pergunta e a resposta na lista
                    if (!string.IsNullOrEmpty(pergunta))
                    {
                        respostas.Add($"{pergunta}: {resposta}");
                    }
                }
            }

            // Exibir dados na MessageBox
            string mensagem = string.Join(Environment.NewLine, respostas);
            MessageBox.Show(mensagem, "Respostas do Formulário");
        }

        private List<Criterio> CarregarCriterios()
        {
            //carrega de forma organizada em listas o conteúdo de cada critério
            List<Criterio> criterios = new List<Criterio>();

            List<Pergunta> infoPrioritarias = new List<Pergunta>
            {
                new Pergunta { Texto = "1.1 Possui sítio oficial próprio na internet?", Flag = "essencial" },
                new Pergunta { Texto = "1.2 Possui portal da transparência próprio ou compartilhado na internet?", Flag = "essencial" },
                new Pergunta { Texto = "1.3 O acesso ao portal transparência está visível na capa do site?", Flag = "Obrigatória" },
                new Pergunta { Texto = "1.4 O site e o portal de transparência contêm ferramenta de pesquisa de conteúdo que permita o acesso à informação?", Flag = "Obrigatória" }
            };

            criterios.Add(new Criterio { Titulo = "1. Informações Prioritárias", Perguntas = infoPrioritarias });

            return criterios;
        }

    }
}
