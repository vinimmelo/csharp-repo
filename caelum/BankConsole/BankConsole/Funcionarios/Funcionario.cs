using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        protected Funcionario (double salario, string cpf) 
        {
            Salario = salario;
            CPF = cpf;
        }

        protected Funcionario () {
            TotalDeFuncionarios++;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
