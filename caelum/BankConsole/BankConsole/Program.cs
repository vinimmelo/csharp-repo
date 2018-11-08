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
            ContaCorrente primeiraConta = new ContaCorrente();
            primeiraConta.saldo = 200;
            Console.WriteLine("Primeira Conta saldo: " + primeiraConta.saldo);
            primeiraConta.saldo += 100;
            Console.WriteLine("Primeira Conta saldo: " + primeiraConta.saldo);
            ContaCorrente segundaConta = new ContaCorrente();
            segundaConta.saldo = 50;

            Console.WriteLine("Segunda conta saldo:" + segundaConta.saldo);

            Console.ReadLine();
        }
    }
}
