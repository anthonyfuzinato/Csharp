using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2ExB
{
    class Program
    {
        static void Main(string[] args)
        {
            Proprietario proprietario = new Proprietario("João Silva", "123456789", "987654321");

            Automovel automovel = new Automovel("12-AB-34", 2020, proprietario, "BMW", "320i", "Gasolina", 60, 8.5);

            Console.WriteLine("Informações do Automóvel:");
            Console.WriteLine(automovel.ExibirDados());
            
            if (automovel.ValidarMatricula())
            {
                Console.WriteLine("Matrícula válida.");
            }
            else
            {
                Console.WriteLine("Matrícula inválida.");
            }

            Console.WriteLine("Nome formatado do proprietário: " + proprietario.TransformarNome());

            automovel.SetMarca("Audi");
            automovel.SetModelo("A4");
            automovel.SetConsumoMedio(7.8);

            Console.WriteLine("\nInformações Atualizadas do Automóvel:");
            Console.WriteLine(automovel.ExibirDados());
        }
    }
}
