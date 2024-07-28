namespace Sistema_de_avaliação_de_Portais_da_Transparência.View
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtSalario = new TextBox();
            lblSalario = new Label();
            btnAdicionar = new Button();
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(26, 76);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 17);
            lblNome.TabIndex = 1;
            lblNome.Tag = "";
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(447, 25);
            txtNome.TabIndex = 2;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(93, 125);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(447, 25);
            txtCargo.TabIndex = 4;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(26, 128);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(44, 17);
            lblCargo.TabIndex = 3;
            lblCargo.Tag = "";
            lblCargo.Text = "Cargo";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(93, 169);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(126, 25);
            txtSalario.TabIndex = 6;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(26, 172);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(48, 17);
            lblSalario.TabIndex = 5;
            lblSalario.Tag = "";
            lblSalario.Text = "Salário";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(465, 166);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 28);
            btnAdicionar.TabIndex = 7;
            btnAdicionar.Text = "Confirmar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // novoFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 258);
            Controls.Add(btnAdicionar);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblNovoFuncionario);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "novoFuncionario";
            Text = "novoFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoFuncionario;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtSalario;
        private Label lblSalario;
        private Button btnAdicionar;
    }
}