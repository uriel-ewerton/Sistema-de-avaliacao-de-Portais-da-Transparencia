using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAPT.Controller;
using SAPT.DTO;
using SAPT.Model;
using static SAPT.Model.Criterio;

namespace SAPT
{
    public partial class FormAvaliacao : Form
    {

        private readonly List<string> _selecoesIniciais = [];
        public FormAvaliacao(List<string> selecoesIniciais)
        {
            InitializeComponent();
            _selecoesIniciais = selecoesIniciais;
            MontarFormulario();
            ShowIcon = false;
        }

        /*
         * Recebe base de critérios e monta controles respectivos em um Panel.
         */
        /*private void MontarFormulario()
        {
            // recupera os criterios no banco
            CriterioController criterioController = new();
            List<CriterioDTO> criterios = criterioController.ListarCriterios();

            // extrai as matrizes para filtrar quais conjuntos de critérios gerar
            List<string> matrizes = [];
            foreach (var c in criterios)
            {
                if (!matrizes.Contains(c.Matriz))
                {
                    matrizes.Add(c.Matriz);
                }
            }
            // guarda as dimensões já lidas. (sera lido no segundo foreach abaixo)
            List<string> dimensoes = [];

            // inicia a montagem dos controles na tela pelas matrizes. 
            int y = 10; // espaçador dos controles na tela
            foreach (string matriz in matrizes)
            {
                // MATRIZ
                Label lblMatriz = new()
                {
                    Name = "lblMatriz",
                    Text = matriz,
                    Font = new Font("Arial", 14),
                    Location = new Point(10, y),
                    Width = 600
                };
                pnlFormulario.Controls.Add(lblMatriz);
                y += 30;

                /* Para cada critério, adiciona:
                 * 1. a dimensão, caso não adicionada antes;
                 * 2. a pergunta
                 * 3. radion buttons para resposta
                 * 4. campo para link ou justificativa.
                 */

        /*   foreach (CriterioDTO criterio in criterios)
             {
                 if (criterio.Matriz.Equals(matriz))
                 {
                     // adiciona a dimensão, caso haja e evita que o mesmo tópico se repita.
                     if (criterio.Dimensao != null && !dimensoes.Contains(criterio.Dimensao))
                     {
                         dimensoes.Add(criterio.Dimensao);
                         // DIMENSÃO
                         Label lblDimensao = new()
                         {
                             Name = "lblDimensao",
                             Text = criterio.Dimensao,
                             Font = new Font("Arial", 12),
                             Location = new Point(10, y),
                             Width = 600
                         };
                         pnlFormulario.Controls.Add(lblDimensao);
                         y += 30;
                     }

                     GroupBox grpPergunta = new()
                     {
                         Text = criterio.Pergunta,
                         Location = new Point(10, y),
                         Width = 750,
                         Height = 55,
                         Tag = criterio.Id  // Usando a propriedade Tag para levar o ID de cada criterio respondido.
                     };
                     // CONSERTAR O ERRO DE NAO ZERAR ESSE CAMPO QUANDO O OCULTA
                     TextBox txtLink = new()
                     {
                         Location = new Point(250, 20),
                         Width = 300,
                         Visible = false,
                         PlaceholderText = "Insira o Link de Justificativa. (Obrigatório)"
                     };
                     //VERIFICAR SE É POSSÍVEL DESMARCAR TOTALMENTE OS RADION BUTTONS, CASO ATIVADOS POR ACASO
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
                     if (criterio.Pergunta.Length >= 250)
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

         }

         Button btnEnviar = new()
         {
             Text = "Concluir Formulário",
             Location = new Point(270, y + 10),
             Width = 200,
             Height = 50
         };
         btnEnviar.Click += EnviarButton_Click;
         pnlFormulario.Controls.Add(btnEnviar);

     }
        */

        private void MontarFormulario()
        {
            // Recupera os criterios no banco
            CriterioController criterioController = new();
            List<CriterioDTO> criterios = criterioController.ListarCriterios();

            // Usa HashSet para verificar presença de matrizes e dimensões de maneira mais eficiente
            HashSet<string> matrizes = new HashSet<string>();
            HashSet<string> dimensoes = new HashSet<string>();

            int y = 10; // Espaçador dos controles na tela

            foreach (CriterioDTO criterio in criterios)
            {
                // Verifica se a matriz já foi adicionada
                if (matrizes.Add(criterio.Matriz))
                {
                    // Adiciona a Label da Matriz
                    Label lblMatriz = new()
                    {
                        Name = "lblMatriz",
                        Text = criterio.Matriz,
                        Font = new Font("Arial", 14),
                        Location = new Point(10, y),
                        Width = 600
                    };
                    pnlFormulario.Controls.Add(lblMatriz);
                    y += 30;
                }

                // Adiciona a dimensão, caso haja, e evita que o mesmo tópico se repita
                if (!string.IsNullOrEmpty(criterio.Dimensao) && dimensoes.Add(criterio.Dimensao))
                {
                    Label lblDimensao = new()
                    {
                        Name = "lblDimensao",
                        Text = criterio.Dimensao,
                        Font = new Font("Arial", 12),
                        Location = new Point(10, y),
                        Width = 600
                    };
                    pnlFormulario.Controls.Add(lblDimensao);
                    y += 30;
                }

                GroupBox grpPergunta = new()
                {
                    Text = criterio.Pergunta,
                    Location = new Point(10, y),
                    Width = 750,
                    Height = 55,
                    Tag = criterio.Id
                };

                TextBox txtLink = new()
                {
                    Location = new Point(250, 20),
                    Width = 300,
                    Visible = false,
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

                if (criterio.Pergunta.Length >= 250)
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

            Button btnEnviar = new()
            {
                Text = "Concluir Formulário",
                Location = new Point(270, y + 10),
                Width = 200,
                Height = 50
            };
            btnEnviar.Click += EnviarButton_Click;
            pnlFormulario.Controls.Add(btnEnviar);
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

            ArgumentNullException.ThrowIfNull(e);
        }

        /* 
         *  Comunica com o controller para validar e gerar o formulário.
         *  Provoca a exibição de resposta de validação ou resultado da avaliação.
         */
        private void EnviarButton_Click(object sender, EventArgs e)
        {
            AvaliacaoController avaliacaoController = new();

            // Testa a avaliação e guarda cópia temporária dos dados
            string respostaValidacao = avaliacaoController.ValidarAvaliacao(pnlFormulario, _selecoesIniciais);

            if (!respostaValidacao.Equals("Validado"))
            {
                MessageBox.Show(respostaValidacao, "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (respostaValidacao.Equals("Validado"))
            {
                // string avaliacao = avaliacaoController.AvaliacaoString();
                string avaliacao = "";// avaliacaoController.UltimaAvaliacaoString();
                var confirmacaoUsuario = MessageBox.Show(avaliacao, "Confirme os Dados",
                    MessageBoxButtons.OKCancel);


                if (confirmacaoUsuario == DialogResult.OK)
                {
                    MessageBox.Show("Avaliação Salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (confirmacaoUsuario == DialogResult.Cancel)
                {
                    avaliacaoController.RemoverUltimaAvaliacao();
                }
            }
        }

    }

}
