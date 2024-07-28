using Sistema_de_avaliação_de_Portais_da_Transparência.Controller;
using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using Sistema_de_avaliação_de_Portais_da_Transparência.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class GerenciadorUsuarios : Form, IFuncionarioView
    {
        private FuncionarioController controller;

        public GerenciadorUsuarios()
        {
            InitializeComponent();
            //Fixa a janela no canto superior direito da tela em relação ao elemento pai
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            dataGridViewFuncionarios.CellClick += dataGridViewFuncionarios_CellContentClick;
            tsbExcluir.Enabled = false;
            tsbEditarFuncionario.Enabled = false;
        }

        public void SetController(FuncionarioController controller)
        {
            this.controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        public void DisplayFuncionarios(List<Funcionario> funcionarios)
        {
            if (funcionarios == null || funcionarios.Count == 0)
            {
                lblnoDataMessage.Visible = true;
                // Pode adicionar uma mensagem de "Nenhum funcionário encontrado" aqui se desejar
                dataGridViewFuncionarios.DataSource = null;
            }
            else
            {
                lblnoDataMessage.Visible = false;
                dataGridViewFuncionarios.DataSource = null;
                dataGridViewFuncionarios.DataSource = funcionarios;
                AjustarColunasDataGridView(); // método para ajustar as colunas após definir a fonte de dados
            }
        }

        private void AjustarColunasDataGridView()
        {
            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            if (dataGridViewFuncionarios.Columns.Count > 0)
            {
                dataGridViewFuncionarios.Columns["Id"].Width = 50;
                dataGridViewFuncionarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionarios.Columns["Cargo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFuncionarios.Columns["Salario"].Width = 100;
            }
        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
            using (novoFuncionario addFuncionarioForm = new novoFuncionario())
            {
                if (addFuncionarioForm.ShowDialog() == DialogResult.OK)
                {
                    var funcionario = new Funcionario
                    {
                        Nome = addFuncionarioForm.FuncionarioNome,
                        Cargo = addFuncionarioForm.FuncionarioCargo,
                        Salario = addFuncionarioForm.FuncionarioSalario
                    };
                    controller.AddFuncionario(funcionario);
                    controller.carregarFuncionarios(); // Atualize a lista após adicionar
                }
            }
        }

        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarFuncionario.Enabled = true;
            tsbExcluir.Enabled = true;
        }

        private void tsbEditarFuncionario_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuncionarios.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewFuncionarios.SelectedRows[0];
                var funcionario = (Funcionario)selectedRow.DataBoundItem;

                using (EditarFuncionario funcionarioForm = new EditarFuncionario())
                {
                    funcionarioForm.adicionarInformacoes(funcionario);

                    if (funcionarioForm.ShowDialog() == DialogResult.OK)
                    {
                        funcionario.Nome = funcionarioForm.FuncionarioNome;
                        funcionario.Cargo = funcionarioForm.FuncionarioCargo;
                        funcionario.Salario = funcionarioForm.FuncionarioSalario;

                        controller.UpdateFuncionario(funcionario);
                        controller.carregarFuncionarios();
                        tsbEditarFuncionario.Enabled = false;
                        dataGridViewFuncionarios.CurrentCell = null;
                    }
                }
            }
        }
        
        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewFuncionarios.SelectedRows[0];
            var funcionario = (Funcionario)selectedRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Deseja excluir o funcionário a seguir?\n" +
            "Id: " + funcionario.Id + "\n" +
            "Nome: " + funcionario.Nome + "\n" +
            "Cargo: " + funcionario.Cargo + "\n" +
            "Salário: " + funcionario.Salario,"ATENÇÃO",MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                DialogResult resultadoDef = MessageBox.Show("Tem Certeza?", "ATENÇÃO", MessageBoxButtons.YesNo);
                if (resultadoDef == DialogResult.Yes)
                {
                    controller.DeleteFuncionario(funcionario.Id);
                    controller.carregarFuncionarios();
                    tsbExcluir.Enabled = false;
                    dataGridViewFuncionarios.CurrentCell = null;
                }
            }


        }
    }
}