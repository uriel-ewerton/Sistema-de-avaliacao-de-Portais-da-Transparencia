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
        /*somente para teste
        private string municipio;
        private string segmento;
        private string tipoAvaliacao;
        */

        private List<List<String>> criterios = [];
        private List<string> infoPrioritarias = [];

        public FormAvaliacao()
        {
            InitializeComponent();
            CarregarListas();
            InitializeForm();
        }

        private void InitializeForm()
        {
            int i = 0;
            foreach (List<String> list in criterios)
            {
                Label titulo = new() { Text = $"{list[0]}", Location = new Point(10, 100 + (i * 30)), Width = 600 };
                panel1.Controls.Add(titulo);
                i++;
                foreach (String str in list.Skip(1))
                {
                    Label questao = new() { Text = $"{str}", Location = new Point(10, 100 + (i * 30)), Width = 600 };
                   // GroupBox opcoes = new() { }
                    panel1.Controls.Add(questao);
                    
                    i++;
                }
            }
        }

        private void CarregarListas()
        {
            //MessageBox.Show(criterios[0].ElementAt(0) + "    " + infoPrioritarias[0]);
            criterios.Add(infoPrioritarias);
            infoPrioritarias.Add("1. Informações Prioritárias");
            infoPrioritarias.Add("1.1 Possui sítio oficial próprio na internet?");
            infoPrioritarias.Add("essencial");
            infoPrioritarias.Add("1.2 Possui portal da transparência próprio ou compartilhado na internet?");
            infoPrioritarias.Add("essencial");
            infoPrioritarias.Add("1.3 O acesso ao portal transparência está visível na capa do site?");
            infoPrioritarias.Add("Obrigatória.");
            infoPrioritarias.Add("1.4 O site e o portal de transparência contêm ferramenta de pesquisa de\r\nconteúdo que permita o acesso à informação?");
            infoPrioritarias.Add("Obrigatória.");

        }
    }
}
