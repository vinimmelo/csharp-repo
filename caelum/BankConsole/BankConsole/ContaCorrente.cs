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
        } 

        public double GetSaldo ()
        {
            return this._saldo;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this._saldo)
            {
                this._saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if(this._saldo >= valor)
            {
                this.Sacar(valor);
                conta.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
