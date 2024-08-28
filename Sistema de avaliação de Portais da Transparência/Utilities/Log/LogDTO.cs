using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.Utilities.Log
{
    public class LogDTO
    {
        public int Id { get; set; }
        public DateTime Entrada {  get; set; }
        public DateTime Saida {  get; set; }
        public string Login {  get; set; } = string.Empty;
        public int Usuario {  get; set; }

        public LogDTO(int id, DateTime entrada, DateTime saida, string login, int usuario)
        {
            Id = id;
            Entrada = entrada;
            Saida = saida;
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Usuario = usuario;
        }

        public LogDTO(DateTime entrada, DateTime saida, string login, int usuario)
        {
            Entrada = entrada;
            Saida = saida;
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Usuario = usuario;
        }

        public LogDTO()
        {
        }
    }
    
}
