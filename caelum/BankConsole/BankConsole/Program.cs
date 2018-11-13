using BankConsole.Funcionarios;
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
            Console.WriteLine(thais.Titular.nome);
            Console.WriteLine(thais.Titular.profissao);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.148-3";
            roberta.Salario = 5000;


            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
