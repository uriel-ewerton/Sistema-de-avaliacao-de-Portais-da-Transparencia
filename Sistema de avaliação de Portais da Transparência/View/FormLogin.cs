using SAPT.Controller;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SAPT
{
    public partial class FormLogin : Form
    {
        //reorganizar movendo para Model usuario + controller login
        const string usuario = "admin";
        const string senha = "123";

        //Login de usuários
        private FuncionarioRepositorio funcionarioRepository = new FuncionarioRepositorio();
        public FormLogin()
        {
            InitializeComponent();
            // Adicionar um funcionário inicial
            Funcionario funcionario = new Funcionario
            {
                Nome = "uriel",
                Cargo = "home",
                Salario = 1500,
                Senha = "12345"
            };
            Funcionario funcionario2 = new Funcionario
            {
                Nome = "pedro",
                Cargo = "funcionarios",
                Salario = 1500,
                Senha = "123456"

            };
            Funcionario funcionario3 = new Funcionario
            {
                Nome = "benjamin",
                Cargo = "avaliacoes",
                Salario = 1500,
                Senha = "1234567"
            };
            var gerenciadorUsuarios = new GerenciadorUsuarios();
            FuncionarioController controller = new FuncionarioController(funcionarioRepository, gerenciadorUsuarios);

            controller.AddFuncionario(funcionario);
            controller.AddFuncionario(funcionario2);
            controller.AddFuncionario(funcionario3);

            ShowIcon = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginValido = false;

            foreach (var funcionario in funcionarioRepository.obterTodos())
            {
                if (txtUsuario.Text.Equals(funcionario.Nome) && txtSenha.Text.Equals(funcionario.Senha))
                {
                    loginValido = true;
                    break; // Encontrou as credenciais corretas, então para a busca
                }
            }

            if (loginValido)
            {
                MessageBox.Show("Login efetuado com sucesso", "Sucesso");
                this.Hide();
                HomePage home = new HomePage(funcionarioRepository);
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
