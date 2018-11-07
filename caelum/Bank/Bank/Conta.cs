using System;
using System.Windows.Forms;

namespace Bank
{
    public class Conta
    {
        public Conta()
        {

        }

        public int Numero { get; set; }

        public double Saldo{ get; private set; }
        public Cliente Titular { get; set; }

        public void Deposita(double valorOperacao)
        {
            if (valorOperacao > 0)
            {
                this.Saldo += valorOperacao;
                MessageBox.Show("Sucesso!!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Valor menor ou igual à zero!!!", "INVÁLIDO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void Saca(double valorOperacao)
        {
            if (valorOperacao <= this.Saldo && valorOperacao > 0)
            {
                this.Saldo -= valorOperacao;
                MessageBox.Show("Sucesso!!!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!!!", "INSUFICIENTE",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}