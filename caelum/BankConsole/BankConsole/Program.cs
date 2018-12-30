using BankConsole.Funcionarios;
using BankConsole.Sistemas;
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

            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ParamName);
            }

            vinicius.Depositar(150);

            Console.WriteLine(vinicius.Titular.nome);
            Console.WriteLine(vinicius.GetSaldo());
            Console.WriteLine(vinicius.Titular.profissao);
            Console.WriteLine(vinicius.Agencia);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine(thais.Titular.nome);
            Console.WriteLine(thais.Titular.profissao);

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer carlos = new Designer("424.864.588-24");
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";

            Diretor roberta = new Diretor("454.658.148-34");
            roberta.Nome = "Roberta";


            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);
            Console.WriteLine(roberta.Salario);
            Console.WriteLine(carlos.Salario);

            roberta.Senha = "2345";
            roberta.Autenticar("2345");

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            SistemaInterno sis = new SistemaInterno();
            sis.Logar(roberta, "2345");
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                conta1.Transferir(10000, conta2);
                //conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Saldo insuficiente!\t" + ex.Message);
            }
            
                 
            Console.ReadLine();
        }
    }
}
