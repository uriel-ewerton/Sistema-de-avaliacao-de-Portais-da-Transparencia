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

namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class FormLogin : Form
    {
        //reorganizar movendo para Model usuario + controller login
        const string usuario = "admin";
        const string senha = "123";

        public FormLogin()
        {
            InitializeComponent();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(usuario) && txtSenha.Text.Equals(senha))
            {
                MessageBox.Show("Login efetuado com sucesso");
                this.Hide();

                HomePage home = new HomePage();
                home.Show();
            }
            else if (!txtUsuario.Text.Equals(usuario) || !txtSenha.Text.Equals(senha))
            {
                MessageBox.Show("Usuário ou Senha incorretos!");
            }
        }
    }
}
