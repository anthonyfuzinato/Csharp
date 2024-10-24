using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Desafio3M9
{
    internal class ContaSimples : ContaBancaria
    {
        public string NumeroCartaoDebito;
        public string NumeroPrimeiroCheque;
        public string NumeroUltimoCheque;

        public ContaSimples(int NConta, string Nome, double Saldo, string _NumeroCartaoDebito, string _NumeroPrimeiroCheque, string _NumeroUltimoCheque)
        : base(NConta, Nome, Saldo) 
        {
            NumeroCartaoDebito = _NumeroCartaoDebito;
            NumeroPrimeiroCheque = _NumeroPrimeiroCheque;
            NumeroUltimoCheque = _NumeroUltimoCheque;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Cartão de Débito: {NumeroCartaoDebito}, Cheques: {NumeroPrimeiroCheque} a {NumeroUltimoCheque}");
        }
    }
}
