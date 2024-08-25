using SAPT.Controller;
using SAPT.DTO;
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
            var avaliacoes = avaliacaoController.ListarAvaliacoes();
            int y = 10;

            foreach (AvaliacaoDTO avaliacao in avaliacoes)
            {
                Label lblNomeAvaliacao = new()
                {
                    Name = "lblNomeAvaliacao",
                    BackColor = Color.FromArgb(165, 231, 250),
                    Text = $"Avaliação {avaliacao.Id + 1}",
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
                    Size = new Size(700, 70),
                    Text = $"Data: {avaliacao.DataAvaliacao}\r\n" +
                           $"Tipo de avaliação: {avaliacao.TipoAvaliacao}" +
                           $"Segmento: {avaliacao.Segmento}\r\n" +
                           $"Município: {avaliacao.Municipio}\r\n" +
                           $"Usuário: x", //SUBSTITUIR QUANDO HOUVER CONTROLER DE USUÁRIOS
                };

                Button btnMostrarAvaliacao = new()
                {
                    Name = "btnMostarAvaliacao",
                    BackColor = Color.White,
                    Text = "Mostrar Avaliação",
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(530, y + 40),
                    Size = new Size(140, 38),
                    Tag = avaliacao.Id
                };

                btnMostrarAvaliacao.Click += btnMostrarAvaliacao_Click;

                pnlAvaliacoes.Controls.Add(lblNomeAvaliacao);
                pnlAvaliacoes.Controls.Add(lblResumoAvaliacao);
                pnlAvaliacoes.Controls.Add(btnMostrarAvaliacao);

                btnMostrarAvaliacao.BringToFront();

                y += 100;
            }

        }
        private void btnMostrarAvaliacao_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                string avaliacaoString = avaliacaoController.AvaliacaoToStringPorId(id);
                MessageBox.Show(avaliacaoString, "Avaliação Selecionada", MessageBoxButtons.OK);
            }


        }


    }
}
