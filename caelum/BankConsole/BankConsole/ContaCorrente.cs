using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class ContaCorrente
    {
        private double _saldo;

        public static int TotalDeContasCriadas { get; private set; }

        public int Numero { get;}
        public int Agencia { get;}

        public Cliente Titular { get; set; }
        private static int TaxaOperacao;

        public ContaCorrente (int agencia, int numero) {
            if (numero <= 0)
            {
                throw new ArgumentException("Número menor ou igual a 0.", nameof(numero));
            }
            else if (agencia <= 0)
            {
                throw new ArgumentException("Agência menor ou igual a 0.", nameof(agencia));
            }
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        } 

        public double GetSaldo ()
        {
            return this._saldo;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor do saque não pode ser negativo.", nameof(valor));
            }

            if(valor > _saldo)
            {

                throw new SaldoInsuficienteException(_saldo, valor);
            }
            _saldo -= valor;
        }

        public void Transferir(double valor, ContaCorrente conta)
        {
            if(_saldo >= valor)
            {
                Sacar(valor);
                conta.Depositar(valor);
                return;
            }
            throw new ArgumentException("Valor inválido para a transferência", nameof(valor));
        }
    }
}
