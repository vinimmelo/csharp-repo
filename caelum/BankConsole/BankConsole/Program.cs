using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente vinicius = new ContaCorrente(46725, 432594)
            {
                Titular = new Cliente
                {
                    nome = "Vinícius",
                    profissao = "Programador"
                }
            };

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente thais = new ContaCorrente(12345, 441123)
            {
                Titular = new Cliente
                {
                    nome = "Thais",
                    profissao = "Barista"
                }

            };

            vinicius.Depositar(150);

            Console.WriteLine(vinicius.Titular.nome);
            Console.WriteLine(vinicius.GetSaldo());
            Console.WriteLine(vinicius.Titular.profissao);
            Console.WriteLine(vinicius.Agencia);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
