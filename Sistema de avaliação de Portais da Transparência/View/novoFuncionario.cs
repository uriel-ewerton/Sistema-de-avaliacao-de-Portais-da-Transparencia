﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.View
{

    public partial class novoFuncionario : Form
    {
        public string FuncionarioNome { get; private set; }
        public string FuncionarioCargo { get; private set; }
        public decimal FuncionarioSalario { get; private set; }

        public novoFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ShowIcon = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtCargo.Text))
            {
                if(decimal.TryParse(txtSalario.Text, out decimal salario))
                {
                    FuncionarioNome = txtNome.Text;
                    FuncionarioCargo = txtCargo.Text;
                    FuncionarioSalario = salario;
                    DialogResult resultado = MessageBox.Show("Funcionario novo\n" +
                        "Nome: " + FuncionarioNome + "\n" +
                        "Cargo: " + FuncionarioCargo + "\n" +
                        "Salário: R$" + FuncionarioSalario, "ATENÇÃO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (resultado == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK; // Configure DialogResult antes de fechar
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("O campo de salário aceita somente números e não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
