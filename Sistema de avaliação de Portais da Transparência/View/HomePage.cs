using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class HomePage : Form
    {
        //controladores
        private readonly CriterioController criterioController;
        private readonly AvaliacaoController avaliacaoController;
        public HomePage()
        {
            InitializeComponent();
            //inicialização dos controladores
            criterioController = new CriterioController();
            criterioController.CarregaCriterios();
            avaliacaoController = new AvaliacaoController();
        }

        private void GerenciadorDeUsuáriosTSMI_Click(object sender, EventArgs e)
        {
            // Criação do repositório e do controlador
            var funcionarioRepository = new FuncionarioRepositorio();
            var gerenciadorUsuarios = new GerenciadorUsuarios();
            var controller = new FuncionarioController(funcionarioRepository, gerenciadorUsuarios);

            // Configura o formulário para usar o controlador
            gerenciadorUsuarios.SetController(controller);

            // Carrega os funcionários e exibe o formulário
            controller.carregarFuncionarios();
            gerenciadorUsuarios.MdiParent = this;
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
                var fazerAvaliacaoForm = new FormAvaliacao(criterioController, avaliacaoController, selecaoForm.SelecoesIniciais);
                fazerAvaliacaoForm.ShowDialog();
            }
        }

        private void ListarAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            ListarAvaliacoes listarAvaliacoes = new(avaliacaoController)
            {
                MdiParent = this
            };
            listarAvaliacoes.Show();
        }
    }
}
