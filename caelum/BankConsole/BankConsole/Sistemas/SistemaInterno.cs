using System;
using BankConsole.Funcionarios;

namespace BankConsole.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha) 
        {
            bool usuarioAutenticavel = funcionario.Autenticar(senha);

            if (usuarioAutenticavel)
            {
                Console.WriteLine("Bem vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
