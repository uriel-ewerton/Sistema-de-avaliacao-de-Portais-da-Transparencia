using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPT.DTO
{
    public class CriterioDTO
    {
        public int Id { get; set; } 
        public string Matriz { get; set; } 
        public string Dimensao { get; set; } 
        public string Pergunta { get; set; } 
        public string Classificacao { get; set; }

        // Construtor que envia ao banco (id auto-increment)
        public CriterioDTO(string matriz, string dimensao, string pergunta, string classificacao)
        {
            Matriz = matriz ?? throw new ArgumentNullException(nameof(matriz));
            Dimensao = dimensao ?? throw new ArgumentNullException(nameof(dimensao));
            Pergunta = pergunta ?? throw new ArgumentNullException(nameof(pergunta));
            Classificacao = classificacao ?? throw new ArgumentNullException(nameof(classificacao));
        }

        // Construtor que recebe do banco
        public CriterioDTO(int id, string matriz, string dimensao, string pergunta, string classificacao)
        {
            Id = id;
            Matriz = matriz ?? throw new ArgumentNullException(nameof(matriz));
            Dimensao = dimensao ?? throw new ArgumentNullException(nameof(dimensao));
            Pergunta = pergunta ?? throw new ArgumentNullException(nameof(pergunta));
            Classificacao = classificacao ?? throw new ArgumentNullException(nameof(classificacao));
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Matriz)}={Matriz}, {nameof(Dimensao)}={Dimensao}, {nameof(Pergunta)}={Pergunta}, {nameof(Classificacao)}={Classificacao}}}";
        }
    }
}
