using System;

namespace POO_ProgramacaoOrientadaAObjeto
{
    class ContaBancaria
    {
        //Atributos privados
        private int numeroConta;
        private string titular;
        private double saldo;

        public int NumeroConta
        {
            get { return numeroConta; }
            private set { numeroConta = value; }
        }

        public string Titular
        {
            get { return titular; }
            private set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Não é possível realizar a operação, pois não consta nenhum valor para depósito");
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Não é possível realizar a operação, pois o saldo não é suficiente para o saque");
                return false;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"{Titular} | Saldo: R${Saldo:F2}");
        }
    }
}
