namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void GerenciadorDeUsuáriosTSMI_Click(object sender, EventArgs e)
        {
            GerenciadorUsuarios gerenciadorUsuarios = new()
            {
                MdiParent = this
            };
            gerenciadorUsuarios.Show();
        }

        private void GerenciadorDeFormuláriosTSMI_Click(object sender, EventArgs e)
        {
            GerenciadorFormularios gerenciadorForm = new()
            {
                MdiParent = this
            };
            gerenciadorForm.Show();
        }

        private void FazerAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            FormAvaliacao formAvaliacao = new()
            {
                MdiParent = this
            };
            formAvaliacao.Show();
        }

        private void ListarAvaliaçãoTSMI_Click(object sender, EventArgs e)
        {
            FormAvaliacao formAvaliacao = new()
            {
                MdiParent = this
            };
            formAvaliacao.Show();
        }
    }
}
