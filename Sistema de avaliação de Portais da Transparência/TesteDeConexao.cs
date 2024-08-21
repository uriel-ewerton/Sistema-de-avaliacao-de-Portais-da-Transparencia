using SAPT.DAO;
using SAPT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPT
{
    public partial class TesteDeConexao : Form
    {
        public TesteDeConexao()
        {
            InitializeComponent();
            MostraUser();
        }
        public void MostraUser()
        {
            TesteDAO testeDAO = new TesteDAO();
            List<TesteDTO> testeDTOList = testeDAO.ListarTodos();
            foreach (TesteDTO x in testeDTOList) {
                
                richTextBox1.Text += $"{x.ToString()}\n";
             }
        }
        
    }
}
