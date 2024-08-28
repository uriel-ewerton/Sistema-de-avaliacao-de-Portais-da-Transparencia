using SAPT.Controller;
using SAPT.DTO;
using SAPT.Model;
using SAPT.Utilities.Log;
using System.Diagnostics;

namespace SAPT
{
    public partial class HomePage : Form
    {
        FuncionarioDTO FuncionarioLogado {  get; set; }
        public HomePage(FuncionarioDTO funcionarioLogado)
        {
            InitializeComponent();
            ShowIcon = false;
            this.FuncionarioLogado = funcionarioLogado;
            //Verifica o nível de acesso do usuário atual
            if (funcionarioLogado.Id != 2)
            {
                GerenciadorDeUsuáriosTSMI.Enabled = false;
                GerenciadorDeFormuláriosTSMI.Enabled = false;
            }
            else
            {
                FazerAvaliaçãoTSMI.Enabled = false;
                ListarAvaliaçãoTSMI.Enabled = false;
            }

            LogController logController = new LogController();
            logController.RegistrarEntrada(funcionarioLogado.Login, funcionarioLogado.Id);
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
                var fazerAvaliacaoForm = new FormAvaliacao(selecaoForm.SelecoesIniciais, FuncionarioLogado);
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
            LogController logController = new LogController();
            logController.RegistrarSaida(FuncionarioLogado.Id);
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair?", "ATENÇÃO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.Yes)
            {
                LogController logController = new LogController();
                bool a = logController.RegistrarSaida(FuncionarioLogado.Id);
                Debug.WriteLine(a);
                Application.Restart();
            }
               
        }
    }
}
