using SAPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAPT.View
{
    public partial class EditarFuncionario : Form
    {
        public string FuncionarioNome { get; private set; }
        public string FuncionarioCargo { get; private set; }
        public decimal FuncionarioSalario { get; private set; }

        public string FuncionarioSenha { get; private set; }
        public EditarFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ShowIcon = false;
        }

        public void adicionarInformacoes(Funcionario funcionario)
        {
            txtNome.Text = funcionario.Nome;
            txtCargo.Text = funcionario.Cargo;
            txtSalario.Text = funcionario.Salario.ToString();
            txtSenha.Text = funcionario.Senha.ToString();
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtCargo.Text))
            {
                if (decimal.TryParse(txtSalario.Text, out decimal salario))
                {
                    FuncionarioNome = txtNome.Text;
                    FuncionarioCargo = txtCargo.Text;
                    FuncionarioSalario = salario;
                    FuncionarioSenha = txtSenha.Text;
                    DialogResult resultado = MessageBox.Show("Funcionario Alterado\n" +
                        "Nome: " + FuncionarioNome + "\n" +
                        "Cargo: " + FuncionarioCargo + "\n" +
                        "Salário: R$" + FuncionarioSalario + "\n" +
                        "Senha: " + FuncionarioSenha, "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (resultado == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("O campo de salário aceita apenas números e não pode estar vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("\"Salário deve ser um valor numérico.\", \"Erro\"");
            }
        }
    }
}
