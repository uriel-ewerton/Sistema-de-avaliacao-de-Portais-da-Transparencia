using SAPT.Controller;
using SAPT.DAO;
using SAPT.DTO;
using System;
using System.Windows.Forms;

namespace SAPT
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            ShowIcon = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FuncionarioController controller = new FuncionarioController();
            List<FuncionarioDTO> funcionarios = controller.carregarFuncionarios();
            FuncionarioDTO funcionarioValido = null;

            string login = txtUsuario.Text;
            string senha = txtSenha.Text;
            int id = 0;

            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Login.Equals(login) && funcionario.Senha.Equals(senha))
                {
                    funcionarioValido = funcionario;
                    id = funcionario.Id;
                    break; // Encontrou as credenciais corretas, então para a busca
                }
            }

            if (funcionarioValido != null)
            {
                MessageBox.Show("Login efetuado com sucesso", "Sucesso");
                this.Hide();
                HomePage home = new HomePage(id);
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}