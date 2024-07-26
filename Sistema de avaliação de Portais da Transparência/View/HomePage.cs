using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class HomePage : Form
    {
        //controladores
        private CriterioController criterioController;
        public HomePage()
        {
            InitializeComponent();
            //inicialização dos controladores
            criterioController = new CriterioController();
            criterioController.CarregaCriterios();
        }

        private void GerenciadorDeUsuáriosTSMI_Click(object sender, EventArgs e)
        {
            GerenciadorUsuarios gerenciadorUsuarios = new()
            {
                MdiParent = this
            };
            gerenciadorUsuarios.Show();
        }

        private void GerenciadorDeFormuláriosTSMI_Click(object sender, EventArgs e)
        {
            GerenciadorFormularios gerenciadorForm = new()
            {
                MdiParent = this
            };
            gerenciadorForm.Show();
        }

        private void FazerAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            using var selecaoForm = new SelecaoInicial();
            if (selecaoForm.ShowDialog() == DialogResult.OK)
            {
                var fazerAvaliacaoForm = new FormAvaliacao(criterioController);
                fazerAvaliacaoForm.ShowDialog();
            }
        }

        private void ListarAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            ListarAvaliacoes listarAvaliacoes = new()
            {
                MdiParent = this
            };
            listarAvaliacoes.Show();
        }
    }
}
