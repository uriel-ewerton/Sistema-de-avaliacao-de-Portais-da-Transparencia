namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    partial class ListarAvaliacoes
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
            pnlAvaliacoes = new Panel();
            SuspendLayout();
            // 
            // pnlAvaliacoes
            // 
            pnlAvaliacoes.AutoScroll = true;
            pnlAvaliacoes.AutoSize = true;
            pnlAvaliacoes.Location = new Point(31, 38);
            pnlAvaliacoes.Name = "pnlAvaliacoes";
            pnlAvaliacoes.Size = new Size(668, 301);
            pnlAvaliacoes.TabIndex = 0;
            // 
            // ListarAvaliacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 380);
            Controls.Add(pnlAvaliacoes);
            MinimizeBox = false;
            Name = "ListarAvaliacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Avaliações";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAvaliacoes;
    }
}