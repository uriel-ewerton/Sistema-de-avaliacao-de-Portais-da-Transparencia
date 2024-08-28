using SAPT.Controller;
using SAPT.DTO;
using SAPT.Model;
using SAPT.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAPT
{
    public partial class GerenciadorUsuarios : Form
    {

        public GerenciadorUsuarios()
        {
            InitializeComponent();
            renderizaFuncionarios();

            //Fixa a janela no canto superior direito da tela em relação ao elemento pai
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            //Adiciona o evento de click em uma célula específica
            dataGridViewFuncionarios.CellClick += dataGridViewFuncionarios_CellContentClick;
            tsbExcluir.Enabled = false;
            tsbEditarFuncionario.Enabled = false;
            ShowIcon = false;
        }

        public void renderizaFuncionarios()
        {
            FuncionarioController controller = new FuncionarioController();
            List<FuncionarioDTO> funcionarios = controller.CarregarFuncionarios();
            DisplayFuncionarios(funcionarios);
        }

        public void DisplayFuncionarios(List<FuncionarioDTO> funcionarios)
        {
            if (funcionarios == null || funcionarios.Count == 0)
            {
                lblnoDataMessage.Visible = true;
                dataGridViewFuncionarios.DataSource = null;
            }
            else
            {
                lblnoDataMessage.Visible = false;
                dataGridViewFuncionarios.DataSource = null;
                dataGridViewFuncionarios.DataSource = funcionarios;
                dataGridViewFuncionarios.CurrentCell = null;
                AjustarColunasDataGridView(); // método para ajustar as colunas após definir a fonte de dados
            }
        }

        private void AjustarColunasDataGridView()
        {
            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dataGridViewFuncionarios.Columns.Count > 0)
            {
                dataGridViewFuncionarios.Columns["Id"].Width = 50;
                dataGridViewFuncionarios.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionarios.Columns["Senha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionarios.Columns["Nivel_Acesso"].Width = 100;
            }
        }
        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarFuncionario.Enabled = true;
            tsbExcluir.Enabled = true;
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            using (novoFuncionario addFuncionarioForm = new novoFuncionario())
            {
                FuncionarioController controller = new FuncionarioController();
                if (addFuncionarioForm.ShowDialog() == DialogResult.OK)
                {
                    var funcionario = new FuncionarioDTO(
                     addFuncionarioForm.FuncionarioLogin,
                     addFuncionarioForm.FuncionarioSenha,
                     addFuncionarioForm.FuncionarioNivelAcesso
                    );
                    controller.AddFuncionario(funcionario.Login, funcionario.Senha, funcionario.Nivel_Acesso);
                    renderizaFuncionarios();
                    tsbEditarFuncionario.Enabled = false;
                    tsbExcluir.Enabled = false;
                }
            }
        }

        private void tsbEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewFuncionarios.SelectedRows[0];
                var funcionario = (FuncionarioDTO)selectedRow.DataBoundItem;

                using (EditarFuncionario funcionarioForm = new EditarFuncionario())
                {
                    funcionarioForm.adicionarInformacoes(funcionario);
                    FuncionarioController controller = new FuncionarioController();

                    if (funcionarioForm.ShowDialog() == DialogResult.OK)
                    {
                        funcionario.Login = funcionarioForm.FuncionarioLogin;
                        funcionario.Senha = funcionarioForm.FuncionarioSenha;
                        funcionario.Nivel_Acesso = funcionarioForm.NivelAcesso;

                        controller.UpdateFuncionario(funcionario.Id, funcionario.Login, funcionario.Senha, funcionario.Nivel_Acesso);
                        renderizaFuncionarios();
                        tsbEditarFuncionario.Enabled = false;
                        tsbExcluir.Enabled = false;
                    }
                }
            }
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewFuncionarios.SelectedRows[0];
            var funcionario = (FuncionarioDTO)selectedRow.DataBoundItem;
            FuncionarioController controller = new FuncionarioController();

            DialogResult resultado = MessageBox.Show("Deseja excluir o funcionário a seguir?\n" +
            "Id: " + funcionario.Id + "\n" +
            "Login: " + funcionario.Login + "\n" +
            "Senha: " + funcionario.Senha + "\n" +
            "Nível de acesso : " + funcionario.Nivel_Acesso, "ATENÇÃO",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                DialogResult resultadoDef = MessageBox.Show("Tem Certeza?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultadoDef == DialogResult.Yes)
                {
                    controller.DeleteFuncionario(funcionario.Id);
                    renderizaFuncionarios();
                    tsbExcluir.Enabled = false;
                    tsbEditarFuncionario.Enabled = false;
                }
            }

        }

        private void GerenciadorUsuarios_Load(object sender, EventArgs e)
        {
            dataGridViewFuncionarios.CurrentCell = null;
        }
    }
}