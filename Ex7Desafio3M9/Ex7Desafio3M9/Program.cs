using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7Desafio3M9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();
            int opcao = -1;

            while (opcao != 0)
            { 
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("----- 1- Criar Conta Corrente Simples -----");
                Console.WriteLine("----- 2- Criar Conta Especial -----");
                Console.WriteLine("----- 3- Criar Conta Poupança -----");
                Console.WriteLine("----- 4- Exibir Informações -----");
                Console.WriteLine("----- 5- Atualizar Saldo -----");
                Console.WriteLine("----- 6- Sair -----");

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    ContaSimples
                }

                if (opcao == 2)
                {

                }

                if (opcao == 3)
                {

                }

                if (opcao == 4)
                {

                }

                else if (opcao == 6)
                {
                    Console.WriteLine("Encerrando o programa.");
                    break;
                }

                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
        }
    }
}
