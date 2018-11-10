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
            ContaCorrente vinicius = new ContaCorrente();
            vinicius.titular = new Cliente();
            vinicius.titular.nome = "Vinícius";
            vinicius.titular.profissao = "Programador";
            vinicius.saldo = 150;

            Console.WriteLine(vinicius.titular.nome);
            Console.WriteLine(vinicius.saldo);
            Console.WriteLine(vinicius.titular.profissao);

            Console.ReadLine();
        }
    }
}
