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
    public partial class SelecaoInicial : Form
    {
        public string Municipio { get; private set; } = string.Empty;
        public string Segmento { get; private set; } = string.Empty;
        public string TipoAvaliacao { get; private set; } = string.Empty;
        public List<string> SelecoesIniciais { get; private set; } = [];
        public SelecaoInicial()
        {
            InitializeComponent();
        }

        private void BtnConfirmarSelecoes_Click(object sender, EventArgs e)
        {
            Municipio = cbxMunicipio.SelectedItem?.ToString() ?? string.Empty;
            Segmento = cbxSegmento.SelectedItem?.ToString() ?? string.Empty;
            TipoAvaliacao = cbxTipoAvaliacao.SelectedItem?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(Municipio)
                && !string.IsNullOrEmpty(Segmento)
                && !string.IsNullOrEmpty(TipoAvaliacao))
            {
                SelecoesIniciais.Add(Municipio);
                SelecoesIniciais.Add(Segmento);
                SelecoesIniciais.Add(TipoAvaliacao);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione todas as opções antes de confirmar.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
