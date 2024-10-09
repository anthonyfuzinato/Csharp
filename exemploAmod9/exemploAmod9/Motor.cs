using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace exemploAmod9
{
    internal class Motor
    {
        private int potencia;
        private string tipoCombustivel;

        public Motor(int _potencia, string tipoCombustivel)
        {
            potencia = _potencia;
            this.tipoCombustivel = tipoCombustivel;
        }

        public void SetPotencia(int _potencia)
        {
            _potencia = Math.Abs(potencia); 
        }

        public int GetPotencia()
        {
            return potencia;
        }

        public void SetTipoCombustivel(string _tipoCombustivel)
        {
            tipoCombustivel = _tipoCombustivel;
        }

        public string GetTipoCombustivel()
        {
            return tipoCombustivel;
        }

        public void ExibirInformacoesMotor()
        {
            Console.WriteLine($"Potência do motor: {potencia} cavalos");
            Console.WriteLine($"Tipo de combustível: {tipoCombustivel}");
        }
    }
}
