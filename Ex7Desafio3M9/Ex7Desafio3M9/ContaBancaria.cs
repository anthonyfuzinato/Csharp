using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Desafio3M9
{
    internal class ContaBancaria
    {
        public int NConta;
        public string Nome;
        public double Saldo;

        public ContaBancaria(int _NConta, string _Nome, double _Saldo)
        {
            NConta = _NConta;
            Nome = _Nome;
            Saldo = _Saldo;
        }
        public virtual void AtualizarSaldo()
        {

        } 
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Conta: {NConta}, Titular: {Nome}, Saldo: {Saldo}");
        }
    }
}
