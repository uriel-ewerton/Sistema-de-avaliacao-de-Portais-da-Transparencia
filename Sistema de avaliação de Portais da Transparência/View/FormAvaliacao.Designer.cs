﻿namespace Sistema_de_avaliação_de_Portais_da_Transparência
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
            pnlFormulario = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            pnlFormulario.AutoScroll = true;
            pnlFormulario.Location = new Point(33, 12);
            pnlFormulario.Margin = new Padding(3, 2, 3, 2);
            pnlFormulario.Name = "panel1";
            pnlFormulario.Size = new Size(750, 346);
            pnlFormulario.TabIndex = 3;
            // 
            // FormAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(812, 369);
            Controls.Add(pnlFormulario);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Avaliação";
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlFormulario;
    }
}