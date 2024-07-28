using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_avaliação_de_Portais_da_Transparência.View
{
    public partial class EditarFuncionario : Form
    {
        public string FuncionarioNome { get; private set; }
        public string FuncionarioCargo { get; private set; }
        public decimal FuncionarioSalario { get; private set; }
        public EditarFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void adicionarInformacoes(Funcionario funcionario)
        {
            txtNome.Text = funcionario.Nome;
            txtCargo.Text = funcionario.Cargo;
            txtSalario.Text = funcionario.Salario.ToString();
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                FuncionarioNome = txtNome.Text;
                FuncionarioCargo = txtCargo.Text;
                FuncionarioSalario = salario;
                DialogResult resultado = MessageBox.Show("Funcionário alterado\n"
                    + "Nome: " + FuncionarioNome + "\n"
                    + "Cargo: " + FuncionarioCargo + "\n"
                    + "Salário: " + FuncionarioSalario,"ATENÇÃO",MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("\"Salário deve ser um valor numérico.\", \"Erro\"");
            }
        }
    }
}
