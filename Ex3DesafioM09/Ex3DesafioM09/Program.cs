using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3DesafioM09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogadorDeFutebol jogador = new JogadorDeFutebol("Anthony", "atacante", "18/07/2008", "brasileiro", 183, 80);
            jogador.ImprimirDados();
        }
    }
}
