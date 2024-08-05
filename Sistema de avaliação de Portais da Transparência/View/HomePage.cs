using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class HomePage : Form
    {
        //controladores
        private readonly CriterioController criterioController;
        private readonly AvaliacaoController avaliacaoController;

        //Repositório de funcionários
        private FuncionarioRepositorio funcionarioRepository = new FuncionarioRepositorio();
          
        public HomePage(FuncionarioRepositorio funcionarioRepository)
        {
            InitializeComponent();
            //Lista de funcionários
            this.funcionarioRepository = funcionarioRepository;

            //inicialização dos controladores
            criterioController = new CriterioController();
            criterioController.CarregaCriterios();
            avaliacaoController = new AvaliacaoController();
            ShowIcon = false;

            //resolve cor cinza da home
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.White;
            }
            //para fechar o programa ao fechar a home
            this.FormClosed += HomePage_FormClosed;
        }

        private void GerenciadorDeFormuláriosTSMI_Click(object sender, EventArgs e)
        {
            ToggleInfoControlsVisibility(false);
            GerenciadorFormularios gerenciadorForm = new()
            {
                MdiParent = this
            };
            gerenciadorForm.FormClosing += (s, args) => ToggleInfoControlsVisibility(true);
            gerenciadorForm.Show();
        }

        private void FazerAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            ToggleInfoControlsVisibility(false);
            using var selecaoForm = new SelecaoInicial();
            if (selecaoForm.ShowDialog() == DialogResult.OK)
            {
                var fazerAvaliacaoForm = new FormAvaliacao(criterioController, avaliacaoController, selecaoForm.SelecoesIniciais);
                fazerAvaliacaoForm.FormClosing += (s, args) => ToggleInfoControlsVisibility(true);
                fazerAvaliacaoForm.Show();
            }
            else
            {
                ToggleInfoControlsVisibility(true);
            }
        }

        private void ListarAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            ToggleInfoControlsVisibility(false);
            ListarAvaliacoes listarAvaliacoes = new(avaliacaoController)
            {
                MdiParent = this
            };
            listarAvaliacoes.FormClosing += (s, args) => ToggleInfoControlsVisibility(true);
            listarAvaliacoes.Show();
        }


        private void ToggleInfoControlsVisibility(bool isVisible)
        {
            grpbCriterios.Visible = isVisible;
            grpbFuncoes.Visible = isVisible;
            grpbSobre.Visible = isVisible;
            lblTitulo.Visible = isVisible;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void GerenciadorDeUsuáriosTSMI_Click_1(object sender, EventArgs e)
        {
            ToggleInfoControlsVisibility(false);

            // Inicializa o gerenciador de usuários
            var gerenciadorUsuarios = new GerenciadorUsuarios();
            var controller = new FuncionarioController(funcionarioRepository, gerenciadorUsuarios);
            gerenciadorUsuarios.SetController(controller);
            controller.carregarFuncionarios();
            gerenciadorUsuarios.MdiParent = this;

            // Adiciona o evento FormClosing para restaurar a visibilidade dos controles
            gerenciadorUsuarios.FormClosing += (s, args) => ToggleInfoControlsVisibility(true);
            gerenciadorUsuarios.Show();
        }
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
