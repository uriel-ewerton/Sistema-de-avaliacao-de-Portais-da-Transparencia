namespace SAPT.View
{
    partial class EditarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNivelAcesso = new TextBox();
            lblNivelAcesso = new Label();
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblFuncionarioExistente = new Label();
            btnConfirmarEdicao = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Location = new Point(465, 149);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(75, 23);
            txtNivelAcesso.TabIndex = 12;
            // 
            // lblNivelAcesso
            // 
            lblNivelAcesso.AutoSize = true;
            lblNivelAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivelAcesso.Location = new Point(359, 150);
            lblNivelAcesso.Name = "lblNivelAcesso";
            lblNivelAcesso.Size = new Size(100, 17);
            lblNivelAcesso.TabIndex = 11;
            lblNivelAcesso.Tag = "";
            lblNivelAcesso.Text = "Nível de acesso";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(93, 69);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(447, 23);
            txtLogin.TabIndex = 10;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(26, 72);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 17);
            lblLogin.TabIndex = 9;
            lblLogin.Tag = "";
            lblLogin.Text = "Login";
            // 
            // lblFuncionarioExistente
            // 
            lblFuncionarioExistente.AutoSize = true;
            lblFuncionarioExistente.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionarioExistente.Location = new Point(12, 20);
            lblFuncionarioExistente.Name = "lblFuncionarioExistente";
            lblFuncionarioExistente.Size = new Size(156, 37);
            lblFuncionarioExistente.TabIndex = 8;
            lblFuncionarioExistente.Text = "Funcionário";
            // 
            // btnConfirmarEdicao
            // 
            btnConfirmarEdicao.Location = new Point(465, 193);
            btnConfirmarEdicao.Name = "btnConfirmarEdicao";
            btnConfirmarEdicao.Size = new Size(75, 23);
            btnConfirmarEdicao.TabIndex = 15;
            btnConfirmarEdicao.Text = "Confirmar";
            btnConfirmarEdicao.UseVisualStyleBackColor = true;
            btnConfirmarEdicao.Click += btnConfirmarEdicao_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 109);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(447, 23);
            txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(26, 112);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(43, 17);
            lblSenha.TabIndex = 16;
            lblSenha.Tag = "";
            lblSenha.Text = "Senha";
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 259);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnConfirmarEdicao);
            Controls.Add(txtNivelAcesso);
            Controls.Add(lblNivelAcesso);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblFuncionarioExistente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarFuncionario";
            Text = "Editar funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txtNivelAcesso;
        private Label lblNivelAcesso;
        private TextBox txtLogin;
        private Label lblLogin;
        private Label lblFuncionarioExistente;
        private Button btnConfirmarEdicao;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}