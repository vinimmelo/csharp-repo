using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class OperacaoFinanceiraException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem)
            : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }

    }
}
