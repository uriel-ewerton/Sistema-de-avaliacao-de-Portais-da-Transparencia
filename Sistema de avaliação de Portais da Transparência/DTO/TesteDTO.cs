using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class TesteDTO
    {
        private int ID {  get; set; }
        private string? Login { get; set; }
        private string? Senha { get; set; }
        private int NivelAcesso {  get; set; }

        public TesteDTO(int iD, string? login, string? senha, int nivelAcesso)
        {
            ID = iD;
            Login = login;
            Senha = senha;
            NivelAcesso = nivelAcesso;
        }
    }
}
