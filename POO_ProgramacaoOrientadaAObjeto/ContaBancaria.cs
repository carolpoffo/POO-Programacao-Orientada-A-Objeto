using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ProgramacaoOrientadaAObjeto
{
    class ContaBancaria
    {
        //atributos privados
        private int numeroConta;
        private string titular;
        private double saldo;

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldoInicial;
        }
        //acessar os atributos
        public int getNumeroConta()
        {
            return numeroConta;
        }
        public string getTitular()
        {
            return titular;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }
        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor) //pode sacar se valor for maior que zero e tiver saldo
            {
                saldo-= valor;
                return true;
            }
            return false;
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"{titular} | Saldo: R${saldo:F2}");
        }
    }
}
