using System;
using BankConsole.Funcionarios;

namespace BankConsole.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
