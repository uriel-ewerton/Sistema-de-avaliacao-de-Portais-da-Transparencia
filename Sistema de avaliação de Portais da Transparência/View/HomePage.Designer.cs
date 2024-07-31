namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            menuStrip1 = new MenuStrip();
            GerenciadoresTSMI = new ToolStripMenuItem();
            GerenciadorDeUsuáriosTSMI = new ToolStripMenuItem();
            GerenciadorDeFormuláriosTSMI = new ToolStripMenuItem();
            AvaliaçõesTSMI = new ToolStripMenuItem();
            FazerAvaliaçãoTSMI = new ToolStripMenuItem();
            ListarAvaliaçãoTSMI = new ToolStripMenuItem();
            lblTitulo = new Label();
            grpbSobre = new GroupBox();
            rtbSobre = new RichTextBox();
            grpbFuncoes = new GroupBox();
            rtbFuncoes = new RichTextBox();
            grpbCriterios = new GroupBox();
            rtbCriterios = new RichTextBox();
            menuStrip1.SuspendLayout();
            grpbSobre.SuspendLayout();
            grpbFuncoes.SuspendLayout();
            grpbCriterios.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { GerenciadoresTSMI, AvaliaçõesTSMI });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(827, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // GerenciadoresTSMI
            // 
            GerenciadoresTSMI.DropDownItems.AddRange(new ToolStripItem[] { GerenciadorDeUsuáriosTSMI, GerenciadorDeFormuláriosTSMI });
            GerenciadoresTSMI.Name = "GerenciadoresTSMI";
            GerenciadoresTSMI.Size = new Size(97, 20);
            GerenciadoresTSMI.Text = "Gerenciadores ";
            // 
            // GerenciadorDeUsuáriosTSMI
            // 
            GerenciadorDeUsuáriosTSMI.Name = "GerenciadorDeUsuáriosTSMI";
            GerenciadorDeUsuáriosTSMI.Size = new Size(220, 22);
            GerenciadorDeUsuáriosTSMI.Text = "Gerenciador de Usuários";
            GerenciadorDeUsuáriosTSMI.Click += GerenciadorDeUsuáriosTSMI_Click;
            // 
            // GerenciadorDeFormuláriosTSMI
            // 
            GerenciadorDeFormuláriosTSMI.Name = "GerenciadorDeFormuláriosTSMI";
            GerenciadorDeFormuláriosTSMI.Size = new Size(220, 22);
            GerenciadorDeFormuláriosTSMI.Text = "Gerenciador de Formulários";
            GerenciadorDeFormuláriosTSMI.Click += GerenciadorDeFormuláriosTSMI_Click;
            // 
            // AvaliaçõesTSMI
            // 
            AvaliaçõesTSMI.DropDownItems.AddRange(new ToolStripItem[] { FazerAvaliaçãoTSMI, ListarAvaliaçãoTSMI });
            AvaliaçõesTSMI.Name = "AvaliaçõesTSMI";
            AvaliaçõesTSMI.Size = new Size(75, 20);
            AvaliaçõesTSMI.Text = "Avaliações";
            // 
            // FazerAvaliaçãoTSMI
            // 
            FazerAvaliaçãoTSMI.Name = "FazerAvaliaçãoTSMI";
            FazerAvaliaçãoTSMI.Size = new Size(161, 22);
            FazerAvaliaçãoTSMI.Text = "Fazer Avaliação";
            FazerAvaliaçãoTSMI.Click += FazerAvaliaçãoTSMI_Click;
            // 
            // ListarAvaliaçãoTSMI
            // 
            ListarAvaliaçãoTSMI.Name = "ListarAvaliaçãoTSMI";
            ListarAvaliaçãoTSMI.Size = new Size(161, 22);
            ListarAvaliaçãoTSMI.Text = "Listar Avaliações";
            ListarAvaliaçãoTSMI.Click += ListarAvaliaçãoTSMI_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.AppWorkspace;
            lblTitulo.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(121, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(550, 27);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Sistema de avaliações de portais da transparência";
            // 
            // grpbSobre
            // 
            grpbSobre.BackColor = SystemColors.ActiveBorder;
            grpbSobre.Controls.Add(rtbSobre);
            grpbSobre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbSobre.Location = new Point(12, 106);
            grpbSobre.Name = "grpbSobre";
            grpbSobre.Size = new Size(543, 114);
            grpbSobre.TabIndex = 8;
            grpbSobre.TabStop = false;
            grpbSobre.Text = "Sobre a aplicação";
            // 
            // rtbSobre
            // 
            rtbSobre.BackColor = SystemColors.ActiveBorder;
            rtbSobre.BorderStyle = BorderStyle.None;
            rtbSobre.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbSobre.Location = new Point(6, 18);
            rtbSobre.Name = "rtbSobre";
            rtbSobre.ReadOnly = true;
            rtbSobre.ScrollBars = RichTextBoxScrollBars.None;
            rtbSobre.Size = new Size(531, 90);
            rtbSobre.TabIndex = 0;
            rtbSobre.Text = resources.GetString("rtbSobre.Text");
            // 
            // grpbFuncoes
            // 
            grpbFuncoes.BackColor = SystemColors.ActiveBorder;
            grpbFuncoes.Controls.Add(rtbFuncoes);
            grpbFuncoes.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbFuncoes.Location = new Point(577, 106);
            grpbFuncoes.Name = "grpbFuncoes";
            grpbFuncoes.Size = new Size(238, 240);
            grpbFuncoes.TabIndex = 10;
            grpbFuncoes.TabStop = false;
            grpbFuncoes.Text = "Funções do sistema";
            // 
            // rtbFuncoes
            // 
            rtbFuncoes.BackColor = SystemColors.ActiveBorder;
            rtbFuncoes.BorderStyle = BorderStyle.None;
            rtbFuncoes.Location = new Point(6, 18);
            rtbFuncoes.Name = "rtbFuncoes";
            rtbFuncoes.ReadOnly = true;
            rtbFuncoes.ScrollBars = RichTextBoxScrollBars.None;
            rtbFuncoes.Size = new Size(214, 65);
            rtbFuncoes.TabIndex = 0;
            rtbFuncoes.Text = "Avaliação;\nListagem de Avaliações;\nGerenciador de funcionários;\nGerenciador de critérios avaliativos.\n";
            // 
            // grpbCriterios
            // 
            grpbCriterios.BackColor = SystemColors.ActiveBorder;
            grpbCriterios.Controls.Add(rtbCriterios);
            grpbCriterios.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpbCriterios.Location = new Point(12, 257);
            grpbCriterios.Name = "grpbCriterios";
            grpbCriterios.Size = new Size(543, 89);
            grpbCriterios.TabIndex = 11;
            grpbCriterios.TabStop = false;
            grpbCriterios.Text = "Sobre os critérios avaliativos";
            // 
            // rtbCriterios
            // 
            rtbCriterios.BackColor = SystemColors.ActiveBorder;
            rtbCriterios.BorderStyle = BorderStyle.None;
            rtbCriterios.Location = new Point(6, 18);
            rtbCriterios.Name = "rtbCriterios";
            rtbCriterios.ReadOnly = true;
            rtbCriterios.ScrollBars = RichTextBoxScrollBars.None;
            rtbCriterios.Size = new Size(531, 65);
            rtbCriterios.TabIndex = 0;
            rtbCriterios.Text = resources.GetString("rtbCriterios.Text");
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 466);
            Controls.Add(grpbCriterios);
            Controls.Add(grpbFuncoes);
            Controls.Add(grpbSobre);
            Controls.Add(lblTitulo);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home - Sistema de Avaliações";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpbSobre.ResumeLayout(false);
            grpbFuncoes.ResumeLayout(false);
            grpbCriterios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem GerenciadoresTSMI;
        private ToolStripMenuItem GerenciadorDeUsuáriosTSMI;
        private ToolStripMenuItem GerenciadorDeFormuláriosTSMI;
        private ToolStripMenuItem AvaliaçõesTSMI;
        private ToolStripMenuItem FazerAvaliaçãoTSMI;
        private ToolStripMenuItem ListarAvaliaçãoTSMI;
        private Label label1;
        private Label label2;
        private Label lblTitulo;
        private GroupBox groupBox1;
        private GroupBox grpbSobre;
        private RichTextBox rtbSobre;
        private GroupBox grpbFuncionalidade;
        private RichTextBox richTextBox1;
        private RichTextBox rtbFuncionalidade;
        private GroupBox grpbFuncoes;
        private RichTextBox rtbFuncoes;
        private GroupBox grpbCriterios;
        private RichTextBox rtbCriterios;
    }
}
