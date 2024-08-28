using SAPT.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.Utilities.Log
{
    public class LogController
    {
        public bool RegistrarEntrada(string login, int user_id)
        {
            LogDAO logDAO = new LogDAO();
            LogDTO logDTO = new LogDTO(DateTime.Now, DateTime.Now, login, user_id);
            return logDAO.Salvar(logDTO);
        }

        public bool RegistrarSaida(int usuario_id)
        {
            LogDAO logDao = new LogDAO();
            if(logDao.AtualizarUltimo(usuario_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
