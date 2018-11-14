using System;
using BankConsole.Funcionarios;

namespace BankConsole.Sistemas
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
        {

        protected FuncionarioAutenticavel(double salario, string cpf) 
            : base(salario, cpf)
        {
        }

        public string Senha
        {
            get;
            set;
        }


        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
