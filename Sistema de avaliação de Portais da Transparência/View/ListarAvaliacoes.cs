using QuestPDF.Fluent;
using QuestPDF.Previewer;
using SAPT.Controller;
using SAPT.DTO;
using SAPT.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPT
{
    public partial class ListarAvaliacoes : Form
    {
        private readonly AvaliacaoController avaliacaoController = new();
        public ListarAvaliacoes()
        {
            InitializeComponent();
            MontarFormulario();
            ShowIcon = false;
        }

        private void MontarFormulario()
        {
            FuncionarioController funcionarioController = new();
            var avaliacoes = avaliacaoController.ListarAvaliacoes();
            int y = 10;

            foreach (AvaliacaoDTO avaliacao in avaliacoes)
            {
                Label lblNomeAvaliacao = new()
                {
                    Name = "lblNomeAvaliacao",
                    BackColor = Color.FromArgb(165, 231, 250),
                    Text = $"Avaliação {avaliacao.Id}",
                    Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold),
                    Location = new Point(40, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(100, 26),
                };

                Label lblResumoAvaliacao = new()
                {
                    BackColor = Color.FromArgb(165, 231, 250),
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(40, y + 25),
                    BorderStyle = BorderStyle.FixedSingle,
                    Name = "lblResumoAvaliacao",
                    Size = new Size(700, 105),
                    Text = $"Data: {avaliacao.DataAvaliacao}\r\n" +
                           $"Tipo de avaliação: {avaliacao.TipoAvaliacao}\r\n" +
                           $"Segmento: {avaliacao.Segmento}\r\n" +
                           $"Município: {avaliacao.Municipio}\r\n" +
                           $"Usuário: {funcionarioController.BuscarPorId(avaliacao.IdUsuario).Login}", 
                };

                Button btnMostrarAvaliacao = new()
                {
                    Name = "btnMostarAvaliacao",
                    BackColor = Color.White,
                    Text = "Pré-visualizar",
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(557, y + 60),
                    Size = new Size(140, 38),
                    Tag = avaliacao.Id
                };

                Button btnGerarPDF = new()
                {
                    Name = "btnGerarPDF",
                    BackColor = Color.White,
                    Text = "Gerar PDF",
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(400, y + 60),
                    Size = new Size(140, 38),
                    Tag = avaliacao.Id
                };

                btnMostrarAvaliacao.Click += btnMostrarAvaliacao_Click;
                btnGerarPDF.Click += btnGerarPDF_Click;

                pnlAvaliacoes.Controls.Add(lblNomeAvaliacao);
                pnlAvaliacoes.Controls.Add(lblResumoAvaliacao);
                pnlAvaliacoes.Controls.Add(btnMostrarAvaliacao);
                pnlAvaliacoes.Controls.Add(btnGerarPDF);

                btnMostrarAvaliacao.BringToFront();
                btnGerarPDF.BringToFront();

                
                y += 150;
            }

        }
        private void btnMostrarAvaliacao_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                //string avaliacaoString = avaliacaoController.AvaliacaoToStringPorId(id);
                AvaliacaoDTO avaliacao = avaliacaoController.AvaliacaoPorId(id);
                var documento = new RelatorioAvaliacao(avaliacao);
                MessageBox.Show("Aguarde a tela de preview aparecer.\nEsse processo" +
                    " pode demorar um pouco.","Processando", MessageBoxButtons.OK);
                documento.ShowInPreviewerAsync();

            }

        }
        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                AvaliacaoDTO avaliacao = avaliacaoController.AvaliacaoPorId(id);
                var documento = new RelatorioAvaliacao(avaliacao);
                /*string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string path = $"C:\\Users\\uriel\\source\\repos\\Sistema de avaliação de Portais da Transparência\\Sistema de avaliação de Portais da Transparência\\RelatoriosPDF\\relatorio_avaliacao{avaliacao.Id}-v{timestamp}.pdf";

                documento.GeneratePdf(path);
                MessageBox.Show("Arquivo PDF gerado localmente", "Sucesso", MessageBoxButtons.OK);*/
                using (SaveFileDialog saveFileDialog = new())
                {
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                    saveFileDialog.FileName = $"relatorio_avaliacao{avaliacao.Id}-v{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        documento.GeneratePdf(saveFileDialog.FileName);
                        MessageBox.Show("Arquivo PDF gerado localmente", "Sucesso", MessageBoxButtons.OK);
                    }
                }
            }

        }


    }
}
