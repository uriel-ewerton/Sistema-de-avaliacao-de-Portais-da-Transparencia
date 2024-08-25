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

            // limpa o foco, que estava indo para o final do formulário
            this.ActiveControl = pnlFormulario;
            ShowIcon = false;
        }

        /*
         * Recebe base de critérios e monta controles respectivos em um Panel.
         */
        private void MontarFormulario()
        {
            // Recupera os criterios no banco
            CriterioController criterioController = new();
            List<CriterioDTO> criterios = criterioController.ListarCriterios();

            // Usa HashSet para verificar presença de matrizes e dimensões de maneira mais eficiente
            HashSet<string> matrizes = [];
            HashSet<string> dimensoes = [];

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
                    Height = 70,
                    Tag = criterio.Id
                };

                TextBox txtLink = new()
                {
                    Location = new Point(250, 35),
                    Width = 300
                };

                RadioButton radAtende = new()
                {
                    Text = "Atende",
                    Location = new Point(10, 35)
                };
                radAtende.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, txtLink);

                RadioButton radNaoAtende = new()
                {
                    Text = "Não Atende",
                    Location = new Point(140, 35)
                };
                radNaoAtende.CheckedChanged += (sender, e) => OnRadioButtonCheckedChanged(sender, e, txtLink);

                // Regula as posições, caso a pergunta(critério) seja muito grande
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
         *  Controla o campo para link ou justificativa
         */
        private static void OnRadioButtonCheckedChanged(object sender, EventArgs e, TextBox linkTextBox)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                if (radioButton.Text.Equals("Não Atende"))
                {
                    linkTextBox.PlaceholderText = "Justificativa Opcional.";
                }
                else
                {
                    linkTextBox.PlaceholderText = "Insira o Link de Justificativa. (Obrigatório)";
                }
                
                // limpa a caixa ao alternar os botões
                if (radioButton.Text.Equals("Atende"))
                {
                    linkTextBox.Text = "";
                }
            }

            ArgumentNullException.ThrowIfNull(e);
        }

        /* 
         *  Comunica com o controller para validar e gerar o formulário.
         *  Provoca a exibição de resposta de validação ou resultado da avaliação.
         *  Solicita o salvamento dos dados no banco.
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
                string avaliacao = avaliacaoController.AvaliacaoToString();
                var confirmacaoUsuario = MessageBox.Show(avaliacao, "Confirme os Dados",
                    MessageBoxButtons.OKCancel);


                if (confirmacaoUsuario == DialogResult.OK )
                {
                    if (avaliacaoController.SalvarAvaliacao())
                    {
                        MessageBox.Show("Avaliação Salva.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        avaliacaoController.LimparCacheAvaliacao();
                    }
                }
                else if (confirmacaoUsuario == DialogResult.Cancel)
                {
                    avaliacaoController.LimparCacheAvaliacao();
                }
            }
        }

    }

}
