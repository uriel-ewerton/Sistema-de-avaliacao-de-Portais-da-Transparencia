namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    partial class GerenciadorUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorUsuarios));
            dataGridViewFuncionarios = new DataGridView();
            lblnoDataMessage = new Label();
            tsFuncionario = new ToolStrip();
            tsbAdicionar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbEditarFuncionario = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbExcluir = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
            tsFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Location = new Point(34, 64);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.Size = new Size(750, 271);
            dataGridViewFuncionarios.TabIndex = 0;
            dataGridViewFuncionarios.CellContentClick += dataGridViewFuncionarios_CellContentClick;
            // 
            // lblnoDataMessage
            // 
            lblnoDataMessage.AutoSize = true;
            lblnoDataMessage.Location = new Point(322, 195);
            lblnoDataMessage.Margin = new Padding(3);
            lblnoDataMessage.Name = "lblnoDataMessage";
            lblnoDataMessage.Size = new Size(182, 16);
            lblnoDataMessage.TabIndex = 8;
            lblnoDataMessage.Text = "Sem funcionários cadastrados";
            // 
            // tsFuncionario
            // 
            tsFuncionario.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFuncionario.Items.AddRange(new ToolStripItem[] { tsbAdicionar, toolStripSeparator1, tsbEditarFuncionario, toolStripSeparator3, tsbExcluir });
            tsFuncionario.Location = new Point(0, 0);
            tsFuncionario.Name = "tsFuncionario";
            tsFuncionario.Size = new Size(833, 25);
            tsFuncionario.TabIndex = 9;
            tsFuncionario.Text = "toolStrip2";
            // 
            // tsbAdicionar
            // 
            tsbAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdicionar.Image = (Image)resources.GetObject("tsbAdicionar.Image");
            tsbAdicionar.ImageTransparentColor = Color.Magenta;
            tsbAdicionar.Name = "tsbAdicionar";
            tsbAdicionar.Size = new Size(126, 22);
            tsbAdicionar.Text = "Adicionar funcionário";
            tsbAdicionar.Click += tsbAdicionar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbEditarFuncionario
            // 
            tsbEditarFuncionario.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEditarFuncionario.Image = (Image)resources.GetObject("tsbEditarFuncionario.Image");
            tsbEditarFuncionario.ImageTransparentColor = Color.Magenta;
            tsbEditarFuncionario.Name = "tsbEditarFuncionario";
            tsbEditarFuncionario.Size = new Size(111, 22);
            tsbEditarFuncionario.Text = "Editar Funcionário";
            tsbEditarFuncionario.Click += tsbEditarFuncionario_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tsbExcluir
            // 
            tsbExcluir.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbExcluir.Image = (Image)resources.GetObject("tsbExcluir.Image");
            tsbExcluir.ImageTransparentColor = Color.Magenta;
            tsbExcluir.Name = "tsbExcluir";
            tsbExcluir.Size = new Size(115, 22);
            tsbExcluir.Text = "Excluir Funcionário";
            tsbExcluir.Click += tsbExcluir_Click;
            // 
            // GerenciadorUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(833, 410);
            Controls.Add(tsFuncionario);
            Controls.Add(lblnoDataMessage);
            Controls.Add(dataGridViewFuncionarios);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GerenciadorUsuarios";
            RightToLeft = RightToLeft.No;
            Text = "Gerenciador de Usuários";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
            tsFuncionario.ResumeLayout(false);
            tsFuncionario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewFuncionarios;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtSalario;
        private TextBox txtId;
        private Label lblnoDataMessage;
        private ToolStrip toolStrip1;
        private ToolStripButton tsAdicionar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adicionarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem editarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private ToolStrip tsFuncionario;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton tsbEditar;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton tsbExcluir;
        private ToolStripButton tsbAdicionar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbEditarFuncionario;
    }
}