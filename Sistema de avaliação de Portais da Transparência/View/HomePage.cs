using SAPT.Controller;
using SAPT.Model;

namespace SAPT
{
    public partial class HomePage : Form
    {
        //Repositório de funcionários
        private FuncionarioRepositorio funcionarioRepository = new FuncionarioRepositorio();
          
        public HomePage(FuncionarioRepositorio funcionarioRepository)
        {
            InitializeComponent();
            //Lista de funcionários
            this.funcionarioRepository = funcionarioRepository;

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
                var fazerAvaliacaoForm = new FormAvaliacao(selecaoForm.SelecoesIniciais);
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
            ListarAvaliacoes listarAvaliacoes = new()
            {
                MdiParent = this
            };
            listarAvaliacoes.FormClosing += (s, args) => ToggleInfoControlsVisibility(true);
            listarAvaliacoes.Show();
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

        // Oculta os componentes da home
        private void ToggleInfoControlsVisibility(bool isVisible)
        {
            grpbCriterios.Visible = isVisible;
            grpbFuncoes.Visible = isVisible;
            grpbSobre.Visible = isVisible;
            lblTitulo.Visible = isVisible;
        }

        // Fecha a aplicação ao fechar a home
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
