namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    partial class FormAvaliacao
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
            municipioLabel = new Label();
            segmentoLabel = new Label();
            tipoAvaliacaoLabel = new Label();
            SuspendLayout();
            // 
            // municipioLabel
            // 
            municipioLabel.AutoSize = true;
            municipioLabel.Location = new Point(110, 129);
            municipioLabel.Name = "municipioLabel";
            municipioLabel.Size = new Size(50, 20);
            municipioLabel.TabIndex = 0;
            municipioLabel.Text = "label1";
            // 
            // segmentoLabel
            // 
            segmentoLabel.AutoSize = true;
            segmentoLabel.Location = new Point(131, 209);
            segmentoLabel.Name = "segmentoLabel";
            segmentoLabel.Size = new Size(50, 20);
            segmentoLabel.TabIndex = 1;
            segmentoLabel.Text = "label2";
            // 
            // tipoAvaliacaoLabel
            // 
            tipoAvaliacaoLabel.AutoSize = true;
            tipoAvaliacaoLabel.Location = new Point(141, 291);
            tipoAvaliacaoLabel.Name = "tipoAvaliacaoLabel";
            tipoAvaliacaoLabel.Size = new Size(50, 20);
            tipoAvaliacaoLabel.TabIndex = 2;
            tipoAvaliacaoLabel.Text = "label3";
            // 
            // FormAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 501);
            Controls.Add(tipoAvaliacaoLabel);
            Controls.Add(segmentoLabel);
            Controls.Add(municipioLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Avaliação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label municipioLabel;
        private Label segmentoLabel;
        private Label tipoAvaliacaoLabel;
    }
}