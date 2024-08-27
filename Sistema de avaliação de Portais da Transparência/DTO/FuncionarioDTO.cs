using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class FuncionarioDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Nivel_Acesso { get; set; }

        // Construtor que envia ao banco (id auto-increment)
        public FuncionarioDTO(string login, string senha, int nivel_acesso)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
            Nivel_Acesso = nivel_acesso;
        }

        // Construtor que recebe do banco
        public FuncionarioDTO(int id, string login, string senha, int nivel_acesso)
        {
            Id = id;
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Senha = senha ?? throw new ArgumentNullException(nameof(senha));
            Nivel_Acesso = nivel_acesso;
        }
    }
}