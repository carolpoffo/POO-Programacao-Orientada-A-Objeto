using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ProgramacaoOrientadaAObjeto
{
    class ContaCorrente : ContaBancaria
    {
        private double taxaSaque = 5.0;

        public ContaCorrente(int numeroConta, string titular, double saldoInicial) : base(numeroConta, titular, saldoInicial) { }

        public override bool Sacar(double valor)
        {
            return base.Sacar(valor + taxaSaque);
        }
    }
}
