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
            txtLogin = new TextBox();
            lblLogin = new Label();
            lblFuncionarioExistente = new Label();
            btnConfirmarEdicao = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            grpbNivelAcesso = new GroupBox();
            rdb1 = new RadioButton();
            rdb2 = new RadioButton();
            grpbNivelAcesso.SuspendLayout();
            SuspendLayout();
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
            btnConfirmarEdicao.Location = new Point(465, 179);
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
            // grpbNivelAcesso
            // 
            grpbNivelAcesso.Controls.Add(rdb1);
            grpbNivelAcesso.Controls.Add(rdb2);
            grpbNivelAcesso.Location = new Point(93, 149);
            grpbNivelAcesso.Name = "grpbNivelAcesso";
            grpbNivelAcesso.Size = new Size(132, 62);
            grpbNivelAcesso.TabIndex = 18;
            grpbNivelAcesso.TabStop = false;
            grpbNivelAcesso.Text = "Nível de acesso";
            // 
            // rdb1
            // 
            rdb1.AutoSize = true;
            rdb1.Location = new Point(18, 30);
            rdb1.Name = "rdb1";
            rdb1.Size = new Size(31, 19);
            rdb1.TabIndex = 11;
            rdb1.TabStop = true;
            rdb1.Text = "1";
            rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            rdb2.AutoSize = true;
            rdb2.Location = new Point(77, 30);
            rdb2.Name = "rdb2";
            rdb2.Size = new Size(31, 19);
            rdb2.TabIndex = 10;
            rdb2.TabStop = true;
            rdb2.Text = "2";
            rdb2.UseVisualStyleBackColor = true;
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 259);
            Controls.Add(grpbNivelAcesso);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnConfirmarEdicao);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(lblFuncionarioExistente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditarFuncionario";
            Text = "Editar funcionario";
            grpbNivelAcesso.ResumeLayout(false);
            grpbNivelAcesso.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private TextBox txtLogin;
        private Label lblLogin;
        private Label lblFuncionarioExistente;
        private Button btnConfirmarEdicao;
        private TextBox txtSenha;
        private Label lblSenha;
        private GroupBox grpbNivelAcesso;
        private RadioButton rdb1;
        private RadioButton rdb2;
    }
}