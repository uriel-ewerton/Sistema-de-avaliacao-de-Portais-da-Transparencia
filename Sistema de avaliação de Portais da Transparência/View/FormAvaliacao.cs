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
        private readonly CriterioController _criterioController;
        private readonly AvaliacaoController _avaliacaoController;
        private List<string> _selecoesIniciais = [];
        public FormAvaliacao(CriterioController criterioController, AvaliacaoController avaliacaoController, List<string> selecoesIniciais)
        {
            InitializeComponent();
            _criterioController = criterioController;
            _avaliacaoController = avaliacaoController;
            _selecoesIniciais = selecoesIniciais;
            MontarFormulario();
        }

        /*
         * Recebe base de critérios e monta controles respectivos em um Panel.
         */
        private void MontarFormulario()
        {
            var criterios = _criterioController.Criterios;
            int y = 10;

            foreach (var criterio in criterios)
            {
                Label lblTitulo = new()
                {
                    Name = "lblTitulo",
                    Text = criterio.Titulo,
                    Font = new Font("Arial", 12),
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
                    
                    Label lblFlag = new()
                    {
                        Name = "lblFlag",
                        Text = pergunta.Flag,
                        Location = new Point(600, 20)
                    };

                    //regula os tamanhos caso o critério exceda 2 linhas
                    if (pergunta.Texto.Length >= 250)
                    {
                        grpPergunta.Height = 75;
                        radAtende.Location = new Point(10, 45);
                        radNaoAtende.Location = new Point(140, 45);
                        txtLink.Location = new Point(250, 45);
                        lblFlag.Location = new Point(600, 45);
                        y += 10;
                    }
                    grpPergunta.Controls.Add(radAtende);
                    grpPergunta.Controls.Add(radNaoAtende);
                    grpPergunta.Controls.Add(txtLink);
                    grpPergunta.Controls.Add(lblFlag);

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

        /*
         *  Controla a exibição do campo para link
         */
        private static void OnRadioButtonCheckedChanged(object sender, EventArgs e, TextBox linkTextBox)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                linkTextBox.Visible = radioButton.Text == "Atende";
            }
        }

        /* 
         *  Comunica com o controller para validar e gerar o formulário.
         *  Provoca a exibição de resposta de validação ou resultado da avaliação.
         */
        private void EnviarButton_Click(object sender, EventArgs e)
        {
            string respostaValidacao = _avaliacaoController.ValidarAvaliacao(pnlFormulario,_selecoesIniciais);

            if (!respostaValidacao.Equals("Validado"))
            {
                MessageBox.Show(respostaValidacao, "Respostas do Formulário",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (respostaValidacao.Equals("Validado"))
            {
                string avaliacao = _avaliacaoController.UltimaAvaliacaoString();
                var confirmacaoUsuario = MessageBox.Show(avaliacao, "Respostas do Formulário", 
                    MessageBoxButtons.OKCancel);
                if (confirmacaoUsuario == DialogResult.OK)
                {
                    this.Close();
                }
                else if(confirmacaoUsuario == DialogResult.Cancel)
                {
                    _avaliacaoController.RemoverUltimaAvaliacao();
                }
            }
        }

    }
    
}
