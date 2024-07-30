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
            menuStrip1 = new MenuStrip();
            GerenciadoresTSMI = new ToolStripMenuItem();
            GerenciadorDeUsuáriosTSMI = new ToolStripMenuItem();
            GerenciadorDeFormuláriosTSMI = new ToolStripMenuItem();
            AvaliaçõesTSMI = new ToolStripMenuItem();
            FazerAvaliaçãoTSMI = new ToolStripMenuItem();
            ListarAvaliaçãoTSMI = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
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
            FazerAvaliaçãoTSMI.Size = new Size(180, 22);
            FazerAvaliaçãoTSMI.Text = "Fazer Avaliação";
            FazerAvaliaçãoTSMI.Click += FazerAvaliaçãoTSMI_Click;
            // 
            // ListarAvaliaçãoTSMI
            // 
            ListarAvaliaçãoTSMI.Name = "ListarAvaliaçãoTSMI";
            ListarAvaliaçãoTSMI.Size = new Size(180, 22);
            ListarAvaliaçãoTSMI.Text = "Listar Avaliações";
            ListarAvaliaçãoTSMI.Click += ListarAvaliaçãoTSMI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 214);
            label1.Name = "label1";
            label1.Size = new Size(248, 15);
            label1.TabIndex = 4;
            label1.Text = "INFORMAÇÕES GERAIS SOBRE O PROGRAMA";
            label1.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 466);
            Controls.Add(label1);
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
    }
}
