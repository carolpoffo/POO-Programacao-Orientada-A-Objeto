using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ProgramacaoOrientadaAObjeto
{
    class ContaPoupanca : ContaBancaria
    {
        private double bonusDeposito = 0.005;

        public ContaPoupanca(int numeroConta, string titular, double saldoInicial) : base(numeroConta, titular, saldoInicial) { }

        public new void Depositar(double valor)
        {
            base.Depositar(valor +(valor * bonusDeposito));
        }
    }
}
