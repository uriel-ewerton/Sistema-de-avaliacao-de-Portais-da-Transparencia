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

    public partial class novoFuncionario : Form
    {
        public string FuncionarioLogin { get; private set; }
        public string FuncionarioSenha { get; private set; }
        public int FuncionarioNivelAcesso { get; private set; }

        public novoFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ShowIcon = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string rdbSelecionado = "";

            if (!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                if (rdb1.Checked || rdb2.Checked)
                {
                    if (rdb1.Checked)
                        rdbSelecionado = rdb1.Text;
                    else
                        rdbSelecionado = rdb2.Text;

                    FuncionarioLogin = txtLogin.Text;
                    FuncionarioNivelAcesso = int.Parse(rdbSelecionado);
                    FuncionarioSenha = txtSenha.Text;
                    DialogResult resultado = MessageBox.Show(
                       "Funcionario novo\n" +
                       "Login: " + FuncionarioLogin + "\n" + 
                       "Senha: " + FuncionarioSenha + "\n" +
                       "Nível de acesso: " + FuncionarioNivelAcesso, "ATENÇÃO", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);
                    if (resultado == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK; // Configure DialogResult antes de fechar
                        this.Close();
                    }
                }
                else
                   MessageBox.Show("Preencha o nível de acesso", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }
    }
}
