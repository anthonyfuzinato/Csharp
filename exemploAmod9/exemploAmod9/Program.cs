using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAmod9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motorV12 = new Motor(800, "Gasolina");

            Carro ferrari = new Carro("Ferrari", motorV12);

            Console.WriteLine("Informações iniciais do carro:");
            ferrari.ExibirInformacoesCarro();

            Motor motorEletrico = new Motor(500, "Elétrico");
            ferrari.SetMotor(motorEletrico);

            Console.WriteLine("\nInformações após a troca do motor:");
            ferrari.ExibirInformacoesCarro();
        }
    }
}
