namespace Sistema_de_avaliação_de_Portais_da_Transparência
{
    partial class SelecaoInicial
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
            lblMunicipio = new Label();
            lblSegmento = new Label();
            lblTipoAvaliacao = new Label();
            txbDescricaoSI = new TextBox();
            cbxMunicipio = new ComboBox();
            cbxSegmento = new ComboBox();
            cbxTipoAvaliacao = new ComboBox();
            BtnConfirmarSelecoes = new Button();
            SuspendLayout();
            // 
            // lblMunicipio
            // 
            lblMunicipio.AutoSize = true;
            lblMunicipio.Font = new Font("Lucida Sans", 12F);
            lblMunicipio.Location = new Point(58, 127);
            lblMunicipio.Name = "lblMunicipio";
            lblMunicipio.Size = new Size(219, 23);
            lblMunicipio.TabIndex = 0;
            lblMunicipio.Text = "Selecionar Município:";
            // 
            // lblSegmento
            // 
            lblSegmento.AutoSize = true;
            lblSegmento.Font = new Font("Lucida Sans", 12F);
            lblSegmento.Location = new Point(58, 187);
            lblSegmento.Name = "lblSegmento";
            lblSegmento.Size = new Size(222, 23);
            lblSegmento.TabIndex = 1;
            lblSegmento.Text = "Selecionar Segmento:";
            // 
            // lblTipoAvaliacao
            // 
            lblTipoAvaliacao.AutoSize = true;
            lblTipoAvaliacao.Font = new Font("Lucida Sans", 12F);
            lblTipoAvaliacao.Location = new Point(58, 241);
            lblTipoAvaliacao.Name = "lblTipoAvaliacao";
            lblTipoAvaliacao.Size = new Size(294, 23);
            lblTipoAvaliacao.TabIndex = 2;
            lblTipoAvaliacao.Text = "Selecionar Tipo de Avaliação:";
            // 
            // txbDescricaoSI
            // 
            txbDescricaoSI.BackColor = SystemColors.Menu;
            txbDescricaoSI.BorderStyle = BorderStyle.None;
            txbDescricaoSI.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbDescricaoSI.Location = new Point(42, 37);
            txbDescricaoSI.Name = "txbDescricaoSI";
            txbDescricaoSI.Size = new Size(717, 28);
            txbDescricaoSI.TabIndex = 3;
            txbDescricaoSI.Text = "Selecione os itens abaixo para gerar o formulário de avaliação:";
            // 
            // cbxMunicipio
            // 
            cbxMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMunicipio.FormattingEnabled = true;
            cbxMunicipio.Items.AddRange(new object[] { "São Luís", "" });
            cbxMunicipio.Location = new Point(464, 132);
            cbxMunicipio.Name = "cbxMunicipio";
            cbxMunicipio.Size = new Size(250, 28);
            cbxMunicipio.TabIndex = 4;
            // 
            // cbxSegmento
            // 
            cbxSegmento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSegmento.FormattingEnabled = true;
            cbxSegmento.Items.AddRange(new object[] { "A" });
            cbxSegmento.Location = new Point(464, 182);
            cbxSegmento.Name = "cbxSegmento";
            cbxSegmento.Size = new Size(250, 28);
            cbxSegmento.TabIndex = 5;
            // 
            // cbxTipoAvaliacao
            // 
            cbxTipoAvaliacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoAvaliacao.FormattingEnabled = true;
            cbxTipoAvaliacao.Items.AddRange(new object[] { "A" });
            cbxTipoAvaliacao.Location = new Point(464, 236);
            cbxTipoAvaliacao.Name = "cbxTipoAvaliacao";
            cbxTipoAvaliacao.Size = new Size(250, 28);
            cbxTipoAvaliacao.TabIndex = 6;
            // 
            // BtnConfirmarSelecoes
            // 
            BtnConfirmarSelecoes.Location = new Point(264, 330);
            BtnConfirmarSelecoes.Name = "BtnConfirmarSelecoes";
            BtnConfirmarSelecoes.Size = new Size(268, 63);
            BtnConfirmarSelecoes.TabIndex = 7;
            BtnConfirmarSelecoes.Text = "Confirmar Seleções";
            BtnConfirmarSelecoes.UseVisualStyleBackColor = true;
            BtnConfirmarSelecoes.Click += BtnConfirmarSelecoes_Click;
            // 
            // SelecaoInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnConfirmarSelecoes);
            Controls.Add(cbxTipoAvaliacao);
            Controls.Add(cbxSegmento);
            Controls.Add(cbxMunicipio);
            Controls.Add(txbDescricaoSI);
            Controls.Add(lblTipoAvaliacao);
            Controls.Add(lblSegmento);
            Controls.Add(lblMunicipio);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelecaoInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleções Iniciais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMunicipio;
        private Label lblSegmento;
        private Label lblTipoAvaliacao;
        private TextBox txbDescricaoSI;
        private ComboBox cbxMunicipio;
        private ComboBox cbxSegmento;
        private ComboBox cbxTipoAvaliacao;
        private Button BtnConfirmarSelecoes;
    }
}