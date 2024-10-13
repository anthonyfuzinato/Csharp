using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBDesafio2
{
    public class Veiculo
    {
        private string _matricula;
        private int _ano;
        private Proprietario _proprietario;

        public Veiculo(string matricula, int ano, Proprietario proprietario)
        {
            _matricula = matricula;
            _ano = ano;
            _proprietario = proprietario;
        }

        public string GetMatricula()
        {
            return _matricula;
        }

        public void SetMatricula(string matricula)
        {
            _matricula = matricula;
        }

        public int GetAno()
        {
            return _ano;
        }

        public void SetAno(int ano)
        {
            _ano = ano;
        }

        public Proprietario GetProprietario()
        {
            return _proprietario;
        }

        public void SetProprietario(Proprietario proprietario)
        {
            _proprietario = proprietario;
        }

        public virtual string ObterDados()
        {
            return $"Matrícula: {_matricula}, Ano: {_ano}, {_proprietario.ObterDados()}";
        }
    }
}
