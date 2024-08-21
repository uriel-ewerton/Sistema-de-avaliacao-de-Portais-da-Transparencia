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
            txtSalario = new TextBox();
            lblSalario = new Label();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblFuncionarioExistente = new Label();
            btnConfirmarEdicao = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            SuspendLayout();
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(93, 196);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(126, 23);
            txtSalario.TabIndex = 14;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(26, 199);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(48, 17);
            lblSalario.TabIndex = 13;
            lblSalario.Tag = "";
            lblSalario.Text = "Salário";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(93, 114);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(447, 23);
            txtCargo.TabIndex = 12;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(26, 117);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(44, 17);
            lblCargo.TabIndex = 11;
            lblCargo.Tag = "";
            lblCargo.Text = "Cargo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(447, 23);
            txtNome.TabIndex = 10;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(26, 72);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 17);
            lblNome.TabIndex = 9;
            lblNome.Tag = "";
            lblNome.Text = "Nome";
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
            txtSenha.Location = new Point(93, 155);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(447, 23);
            txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(26, 158);
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
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
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
        private TextBox txtSalario;
        private Label lblSalario;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtNome;
        private Label lblNome;
        private Label lblFuncionarioExistente;
        private Button btnConfirmarEdicao;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}