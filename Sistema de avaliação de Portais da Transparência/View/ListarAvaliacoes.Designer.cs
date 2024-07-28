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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            pnlAvaliacoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAvaliacoes
            // 
            pnlAvaliacoes.AutoScroll = true;
            pnlAvaliacoes.Controls.Add(button2);
            pnlAvaliacoes.Controls.Add(textBox2);
            pnlAvaliacoes.Controls.Add(label2);
            pnlAvaliacoes.Controls.Add(button1);
            pnlAvaliacoes.Controls.Add(textBox1);
            pnlAvaliacoes.Controls.Add(label1);
            pnlAvaliacoes.Location = new Point(31, 38);
            pnlAvaliacoes.Name = "pnlAvaliacoes";
            pnlAvaliacoes.Size = new Size(668, 301);
            pnlAvaliacoes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(17, 121);
            label1.Name = "label1";
            label1.Size = new Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "Avaliação 1";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Quicksand SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(17, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(628, 69);
            textBox1.TabIndex = 1;
            textBox1.Text = "data: meu pau na tua mao\r\nINfo1: asdqwodnqwd\r\ninfo2: nadsk65a4dsa5sd";
            // 
            // button1
            // 
            button1.Location = new Point(487, 46);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 2;
            button1.Text = "Mostrar Avaliação";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(17, 142);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(628, 61);
            textBox2.TabIndex = 4;
            textBox2.Text = "data: meu pau na tua mao\r\nINfo1: asdqwodnqwd\r\ninfo2: nadsk65a4dsa5sd";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Quicksand SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 13);
            label2.Name = "label2";
            label2.Size = new Size(100, 26);
            label2.TabIndex = 3;
            label2.Text = "Avaliação 2";
            // 
            // button2
            // 
            button2.Location = new Point(487, 151);
            button2.Name = "button2";
            button2.Size = new Size(118, 38);
            button2.TabIndex = 5;
            button2.Text = "Mostrar Avaliação";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListarAvaliacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pnlAvaliacoes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarAvaliacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Avaliações";
            pnlAvaliacoes.ResumeLayout(false);
            pnlAvaliacoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAvaliacoes;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}