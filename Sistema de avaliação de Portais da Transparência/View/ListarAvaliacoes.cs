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
                int count = 1;
                Label lblNomeAvaliacao = new()
                {
                    Name = "lblNomeAvaliacao",
                    Text = $"Avaliação {count}",
                    Font = new Font("Arial", 12),
                    Location = new Point(10, y),
                };
                pnlAvaliacoes.Controls.Add(lblNomeAvaliacao);
                
                Button btnMostarAvaliacao = new()
                {
                    Name = "btnMostarAvaliacao",
                    Text = "Mostar Avaliacao",
                    Font = new Font("Arial", 12),
                    Location = new Point(400, y),
                };
                y += 30;
            }
        }
    }
}
