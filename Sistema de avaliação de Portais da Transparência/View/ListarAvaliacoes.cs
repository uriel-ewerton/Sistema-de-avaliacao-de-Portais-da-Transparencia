using SAPT.Controller;
using SAPT.Model;
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
        private readonly AvaliacaoController _avaliacaoController;
        public ListarAvaliacoes(AvaliacaoController avaliacaoController)
        {
            InitializeComponent();
            _avaliacaoController = avaliacaoController;
            MontarFormulario();
            ShowIcon = false;
        }

        private void MontarFormulario()
        {
            var avaliacoes = _avaliacaoController.Avaliacoes;
            int y = 10;

            foreach (Avaliacao avaliacao in avaliacoes)
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
                    Size = new Size(700, 70),
                    Text = $"Data: {avaliacao.Timestamp}\r\nMunicípio: {avaliacao.Municipio}\r\nSegmento: {avaliacao.Segmento}",
                };

                Button btnMostrarAvaliacao = new()
                {
                    Name = "btnMostarAvaliacao",
                    BackColor = Color.White,
                    Text = "Mostrar Avaliação",
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(530, y + 40),
                    Size = new Size(140, 38),
                    Tag = avaliacao
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
            if (sender is Button btn && btn.Tag is Avaliacao avaliacao)
            {
                string avaliacaoString = _avaliacaoController.AvaliacaoToString((Avaliacao)btn.Tag);
                MessageBox.Show(avaliacaoString, "Avaliação Selecionada", MessageBoxButtons.OK);
            }
               

        }

        
    }
}
