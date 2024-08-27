namespace SAPT.View
{
    partial class novoFuncionario
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
            lblNovoFuncionario = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtNivelAcesso = new TextBox();
            lblNivelAcesso = new Label();
            btnAdicionar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // lblNovoFuncionario
            // 
            lblNovoFuncionario.AutoSize = true;
            lblNovoFuncionario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNovoFuncionario.Location = new Point(12, 10);
            lblNovoFuncionario.Name = "lblNovoFuncionario";
            lblNovoFuncionario.Size = new Size(228, 37);
            lblNovoFuncionario.TabIndex = 0;
            lblNovoFuncionario.Text = "Novo Funcionário";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(26, 76);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 17);
            lblLogin.TabIndex = 1;
            lblLogin.Tag = "";
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(93, 73);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(447, 25);
            txtLogin.TabIndex = 2;
            // 
            // txtNivelAcesso
            // 
            txtNivelAcesso.Location = new Point(432, 158);
            txtNivelAcesso.Name = "txtNivelAcesso";
            txtNivelAcesso.Size = new Size(108, 25);
            txtNivelAcesso.TabIndex = 4;
            // 
            // lblNivelAcesso
            // 
            lblNivelAcesso.AutoSize = true;
            lblNivelAcesso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNivelAcesso.Location = new Point(326, 161);
            lblNivelAcesso.Name = "lblNivelAcesso";
            lblNivelAcesso.Size = new Size(100, 17);
            lblNivelAcesso.TabIndex = 3;
            lblNivelAcesso.Tag = "";
            lblNivelAcesso.Text = "Nivel de acesso";
            lblNivelAcesso.Click += lblCargo_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(465, 201);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 28);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Confirmar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 118);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(447, 25);
            txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(26, 121);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(43, 17);
            lblSenha.TabIndex = 8;
            lblSenha.Tag = "";
            lblSenha.Text = "Senha";
            // 
            // novoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 258);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNivelAcesso);
            Controls.Add(lblNivelAcesso);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblNovoFuncionario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "novoFuncionario";
            Text = "Novo funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoFuncionario;
        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtNivelAcesso;
        private Label lblNivelAcesso;
        private Button btnAdicionar;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}