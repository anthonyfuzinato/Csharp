using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9Desafio3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Alice", 28, "São Paulo");
            Pessoa pessoa2 = new Pessoa("Bruno", 35, "Rio de Janeiro");
            Pessoa pessoa3 = new Pessoa("Carla", 22, "Viseu");

            pessoa1.ExibirDetalhes();
            pessoa2.ExibirDetalhes();
            pessoa3.ExibirDetalhes();
        }
    }
}
