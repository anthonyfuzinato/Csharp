using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Desafio3M9
{
    internal class ContaEspecial : ContaBancaria
    {
        public double LimiteCredito;
        public double SaldoUtilizado;
        public string NumeroCartaoDebito;
        public string NumeroPrimeiroCheque;
        public string NumeroUltimoCheque;

        public ContaEspecial(int NConta, string Nome, double Saldo, double _LimiteCredito, double _SaldoUtilizado,string _NumeroCartaoDebito, string _NumeroPrimeiroCheque, string _NumeroUltimoCheque)
        : base(NConta, Nome, Saldo)
        {
            LimiteCredito = _LimiteCredito;
            SaldoUtilizado = _SaldoUtilizado;
            NumeroCartaoDebito = _NumeroCartaoDebito;
            NumeroPrimeiroCheque = _NumeroPrimeiroCheque;
            NumeroUltimoCheque = _NumeroUltimoCheque;
        }
        public override void AtualizarSaldo()
        {
            Saldo -= SaldoUtilizado;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cartão de Débito: {NumeroCartaoDebito}, Cheques: {NumeroPrimeiroCheque} a {NumeroUltimoCheque}, Limite de Crédito: {LimiteCredito:C}, Saldo Utilizado: {SaldoUtilizado:C}");
        }
    }
}
