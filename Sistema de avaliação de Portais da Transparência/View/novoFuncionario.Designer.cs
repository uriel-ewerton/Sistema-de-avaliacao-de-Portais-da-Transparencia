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
            btnAdicionar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            rdb2 = new RadioButton();
            rdb1 = new RadioButton();
            grpbNivelAcesso = new GroupBox();
            grpbNivelAcesso.SuspendLayout();
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
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(465, 179);
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
            // rdb2
            // 
            rdb2.AutoSize = true;
            rdb2.Location = new Point(77, 30);
            rdb2.Name = "rdb2";
            rdb2.Size = new Size(33, 21);
            rdb2.TabIndex = 10;
            rdb2.TabStop = true;
            rdb2.Text = "2";
            rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(18, 30);
            rdb1.Name = "rdb1";
            rdb1.Size = new Size(33, 21);
            rdb1.TabIndex = 11;
            rdb1.TabStop = true;
            rdb1.Text = "1";
            rdb1.UseVisualStyleBackColor = true;
            // 
            // grpbNivelAcesso
            // 
            grpbNivelAcesso.Controls.Add(rdb1);
            grpbNivelAcesso.Controls.Add(rdb2);
            grpbNivelAcesso.Location = new Point(93, 149);
            grpbNivelAcesso.Name = "grpbNivelAcesso";
            grpbNivelAcesso.Size = new Size(132, 62);
            grpbNivelAcesso.TabIndex = 12;
            grpbNivelAcesso.TabStop = false;
            grpbNivelAcesso.Text = "Nível de acesso";
            // 
            // novoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 258);
            Controls.Add(grpbNivelAcesso);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnAdicionar);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblNovoFuncionario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "novoFuncionario";
            Text = "Novo funcionario";
            grpbNivelAcesso.ResumeLayout(false);
            grpbNivelAcesso.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoFuncionario;
        private Label lblLogin;
        private TextBox txtLogin;
        private Button btnAdicionar;
        private TextBox txtSenha;
        private Label lblSenha;
        private RadioButton rdb2;
        private RadioButton rdb1;
        private GroupBox grpbNivelAcesso;
    }
}