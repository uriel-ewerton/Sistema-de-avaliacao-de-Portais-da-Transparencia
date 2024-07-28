using Sistema_de_avaliação_de_Portais_da_Transparência.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_avaliação_de_Portais_da_Transparência.View;

namespace Sistema_de_avaliação_de_Portais_da_Transparência.Controller
{
    public class FuncionarioController
    {
        //readonly garante que o repositório será atribuido uma vez somente durante o tempo de vida útil
        //do programa
        private readonly IFuncionarioRepositorio repositorio;
        private readonly IFuncionarioView view;

        public FuncionarioController(IFuncionarioRepositorio repositorio, IFuncionarioView view)
        {
            this.repositorio = repositorio;
            this.view = view;
            this.view.SetController(this);
        }

        public void carregarFuncionarios()
        {
            //Carrega os funcionários sempre que uma alteração acontecer na lista
            var funcionarios = repositorio.obterTodos();
            view.DisplayFuncionarios(funcionarios);
  
        }

        public void AddFuncionario(Funcionario funcionario)
        {
            repositorio.Add(funcionario);
            carregarFuncionarios();
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            repositorio.Update(funcionario);
            carregarFuncionarios();
        }

        public void DeleteFuncionario(int id)
        {
            repositorio.Delete(id);
            carregarFuncionarios();
        }
    }
}
