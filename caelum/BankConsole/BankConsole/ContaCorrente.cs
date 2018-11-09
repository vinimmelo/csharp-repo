using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class ContaCorrente
    {
        public double saldo;
        public int numero;
        public int agencia;
        public string nome;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if(this.saldo >= valor)
            {
                this.Sacar(valor);
                conta.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
