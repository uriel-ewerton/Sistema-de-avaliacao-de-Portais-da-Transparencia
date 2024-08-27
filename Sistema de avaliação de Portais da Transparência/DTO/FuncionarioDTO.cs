﻿using System;
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
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public string Senha { get; set; } = string.Empty;
    }
}
