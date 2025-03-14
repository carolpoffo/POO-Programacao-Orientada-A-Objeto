namespace POO_ProgramacaoOrientadaAObjeto
{
    public class Program
    {
        static void Main()
        {
            ContaCorrente cc = new ContaCorrente(123, "Carolina Poffo", 1000);
            cc.Depositar(500);
            cc.Sacar(200);
            cc.ExibirSaldo();

            ContaPoupanca cp = new ContaPoupanca(456, "Yasmim Poffo", 2000);
            cp.Depositar(1000);
            cp.Sacar(400);
            cp.ExibirSaldo();
        }
    }
}