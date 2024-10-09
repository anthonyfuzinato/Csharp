using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2ExB
{
    public class Automovel : Veiculo
    {
        private string _marca;
        private string _modelo;
        private string _tipoCombustivel;
        private int _numeroMaxLitrosDeposito;
        private double _consumoMedio;

        public Automovel(string matricula, int ano, Proprietario proprietario, string marca, string modelo, string tipoCombustivel, int numeroMaxLitrosDeposito, double consumoMedio)
            : base(matricula, ano, proprietario)
        {
            _marca = marca;
            _modelo = modelo;
            _tipoCombustivel = tipoCombustivel;
            _numeroMaxLitrosDeposito = numeroMaxLitrosDeposito;
            _consumoMedio = consumoMedio;
        }

        public void SetMarca(string marca)
        {
            _marca = marca;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetTipoCombustivel(string tipoCombustivel)
        {
            _tipoCombustivel = tipoCombustivel;
        }

        public string GetTipoCombustivel()
        {
            return _tipoCombustivel;
        }

        public void SetNumeroMaxLitrosDeposito(int numeroMaxLitrosDeposito)
        {
            _numeroMaxLitrosDeposito = numeroMaxLitrosDeposito;
        }

        public int GetNumeroMaxLitrosDeposito()
        {
            return _numeroMaxLitrosDeposito;
        }

        public void SetConsumoMedio(double consumoMedio)
        {
            _consumoMedio = consumoMedio;
        }

        public double GetConsumoMedio()
        {
            return _consumoMedio;
        }

        public override string ExibirDados()
        {
            return $"{base.ExibirDados()}, Marca: {_marca}, Modelo: {_modelo}, Combustível: {_tipoCombustivel}, " +
                   $"Capacidade Depósito: {_numeroMaxLitrosDeposito} litros, Consumo Médio: {_consumoMedio} l/100km";
        }
    }
}

