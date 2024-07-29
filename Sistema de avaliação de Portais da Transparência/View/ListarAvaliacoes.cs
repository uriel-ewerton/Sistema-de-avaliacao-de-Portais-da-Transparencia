using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
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
    public partial class ListarAvaliacoes : Form
    {
        private readonly AvaliacaoController _avaliacaoController;
        public ListarAvaliacoes(AvaliacaoController avaliacaoController)
        {
            InitializeComponent();
            _avaliacaoController = avaliacaoController;
            MontarFormulario();
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
                    Text = $"Avaliação {avaliacao.Id}",
                    Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold),
                    Location = new Point(40, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(100, 26),
                };

                Label lblResumoAvaliacao = new()
                {
                    BackColor = SystemColors.Info,
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(40, y + 25),
                    Name = "lblResumoAvaliacao",
                    Size = new Size(650, 70),
                    Text = $"Data: {avaliacao.Timestamp}\r\nMunicípio: {avaliacao.Municipio}\r\nSegmento: {avaliacao.Segmento}",
                };

                Button btnMostrarAvaliacao = new()
                {
                    Name = "btnMostarAvaliacao",
                    Text = "Mostrar Avaliação",
                    Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    Location = new Point(500, y + 40),
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
