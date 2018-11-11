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
        private int _numero;
        private int _agencia;

        public static int TotalDeContasCriadas { get; private set; }

        public int Numero { 
            get
            {
                return _numero;
            } 
            set 
            {
                if (value > 0) {
                    _numero = value;
                }
                return;
            } 
        }
        public int Agencia { 
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0) {
                    return;
                }
                _agencia = value;
            }
        }

        public Cliente Titular { get; set; }

        public ContaCorrente (int agencia, int numero) {
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
