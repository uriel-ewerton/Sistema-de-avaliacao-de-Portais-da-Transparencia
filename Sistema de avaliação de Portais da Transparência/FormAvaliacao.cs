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
        //somente para teste
        private string municipio;
        private string segmento;
        private string tipoAvaliacao;
        public FormAvaliacao(string municipio, string segmento, string tipoAvaliacao)
        {
            InitializeComponent();
            this.municipio = municipio;
            this.segmento = segmento;
            this.tipoAvaliacao = tipoAvaliacao;
            InitializeForm();
        }

        private void InitializeForm()
        {
            municipioLabel.Text = municipio;
            segmentoLabel.Text = segmento;
            tipoAvaliacaoLabel.Text = tipoAvaliacao;
        }
    }
}
