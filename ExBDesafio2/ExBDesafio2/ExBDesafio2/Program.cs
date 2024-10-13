using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBDesafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // usei chat gpt em algumas partes do codigo q eu nao conseguia perceber uma soluçao melhor


            Proprietario proprietario1 = new Proprietario("João Silva", "12345678", "987654321");

           
            Veiculo veiculo1 = new Veiculo("12-AB-34", 2010, proprietario1);
            Console.WriteLine("Dados do Veículo:");
            Console.WriteLine(veiculo1.ObterDados());

            
            Automovel automovel1 = new Automovel("56-CD-78", 2020, proprietario1, "Toyota", "Corolla", "Gasóleo", 50, 5.5);
            Console.WriteLine("\nDados do Automóvel:");
            Console.WriteLine(automovel1.ObterDados());

            
            double autonomia = automovel1.CalcularAutonomia();
            Console.WriteLine($"\nA autonomia com o depósito cheio é: {autonomia:F2} km");

         
            double custoEncherDeposito = automovel1.CalcularCustoEncherDeposito();
            Console.WriteLine($"O custo para encher o depósito é: {custoEncherDeposito:F2} €");
        }
    }
}
