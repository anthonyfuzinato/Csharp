using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBDesafio2
{
    public class Automovel : Veiculo
    {
        private string _marca;
        private string _modelo;
        private string _tipoCombustivel;
        private double _capacidadeDeposito;
        private double _consumoMedio;

        public Automovel(string matricula, int ano, Proprietario proprietario, string marca, string modelo, string tipoCombustivel, double capacidadeDeposito, double consumoMedio)
            : base(matricula, ano, proprietario)
        {
            _marca = marca;
            _modelo = modelo;
            _tipoCombustivel = tipoCombustivel;
            _capacidadeDeposito = capacidadeDeposito;
            _consumoMedio = consumoMedio;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public void SetMarca(string marca)
        {
            _marca = marca;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }

        public string GetTipoCombustivel()
        {
            return _tipoCombustivel;
        }

        public void SetTipoCombustivel(string tipoCombustivel)
        {
            _tipoCombustivel = tipoCombustivel;
        }

        public double GetCapacidadeDeposito()
        {
            return _capacidadeDeposito;
        }

        public void SetCapacidadeDeposito(double capacidadeDeposito)
        {
            _capacidadeDeposito = capacidadeDeposito;
        }

        public double GetConsumoMedio()
        {
            return _consumoMedio;
        }

        public void SetConsumoMedio(double consumoMedio)
        {
            _consumoMedio = consumoMedio;
        }

        public override string ObterDados()
        {
            return base.ObterDados() + $", Marca: {_marca}, Modelo: {_modelo}, Combustível: {_tipoCombustivel}";
        }

        public double CalcularAutonomia()
        {
            return (_capacidadeDeposito / _consumoMedio) * 100;
        }

        public double CalcularCustoEncherDeposito()
        {
            double precoPorLitro = 0;

            if (_tipoCombustivel.ToLower() == "gasolina 98")
            {
                precoPorLitro = 1.954;
            }
            else if (_tipoCombustivel.ToLower() == "gasóleo")
            {
                precoPorLitro = 1.704;
            }
            else if (_tipoCombustivel.ToLower() == "gpl")
            {
                precoPorLitro = 0.924;
            }
            else
            {
                Console.WriteLine("Tipo de combustível desconhecido. Definindo preço como 0.");
                return 0;
            }

            return _capacidadeDeposito * precoPorLitro;
        }
    }
}
