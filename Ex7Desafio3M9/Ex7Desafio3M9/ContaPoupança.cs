using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Desafio3M9
{
    internal class ContaPoupança : ContaBancaria
    {
        public DateTime AniversarioData;

        public ContaPoupança(int NConta, string Nome, double Saldo, DateTime _AniversarioData)
        : base(NConta, Nome, Saldo)
        {
            AniversarioData = _AniversarioData;
        }

        public override void AtualizarSaldo()
        {
            Saldo += Saldo * 0.02;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Data de Aniversário: {AniversarioData.ToShortDateString()}");
        }
    }
}
