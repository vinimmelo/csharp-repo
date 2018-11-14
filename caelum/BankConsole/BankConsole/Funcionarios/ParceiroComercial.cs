using System;
using BankConsole.Sistemas;

namespace BankConsole.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        public ParceiroComercial()
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
