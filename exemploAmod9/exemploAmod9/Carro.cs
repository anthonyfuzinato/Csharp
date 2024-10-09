using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAmod9
{
    internal class Carro
    {
        private string marca;
        private Motor motorCarro;

        public Carro(string _marca, Motor _motor)
        {
            marca = _marca;
            motorCarro = _motor;
        }

        public void SetMarca(string _marca)
        {
            marca = _marca;
        }

        public void SetMotor(Motor motor)
        {
            this.motorCarro = motor;
        }

        public void ExibirInformacoesCarro()
        {
            Console.WriteLine($"Marca do carro: {marca}");
            motorCarro.ExibirInformacoesMotor();
        }
    }
}
