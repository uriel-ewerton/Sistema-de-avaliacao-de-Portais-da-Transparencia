using SAPT.DTO;
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
        public string FuncionarioLogin { get; private set; }
        public string FuncionarioSenha { get; private set; }
        public int NivelAcesso { get; private set; }

        public EditarFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ShowIcon = false;
        }

        public void adicionarInformacoes(FuncionarioDTO funcionario)
        {
            txtLogin.Text = funcionario.Login;
            txtSenha.Text = funcionario.Senha;
            if (funcionario.Nivel_Acesso.Equals("1"))
            {
                rdb1.Checked = true;
            }
            else
                rdb1.Checked = true;
        }

        private void btnConfirmarEdicao_Click(object sender, EventArgs e)
        {
            string novoNivelAcesso = "";

            if(!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(txtSenha.Text))
            {
                if (rdb1.Checked || rdb2.Checked)
                {
                    if (rdb1.Checked)
                        novoNivelAcesso = rdb1.Text;
                    else
                        novoNivelAcesso = rdb2.Text;

                    FuncionarioLogin = txtLogin.Text;
                    FuncionarioSenha = txtSenha.Text;
                    NivelAcesso = int.Parse(novoNivelAcesso);

                    DialogResult resultado = MessageBox.Show("Funcionario Alterado\n" +
                        "Login: " + FuncionarioLogin + "\n" +
                        "Senha: " + FuncionarioSenha + "\n" +
                        "Nível de acesso: " + NivelAcesso , "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (resultado == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Escolha um nível de acesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
