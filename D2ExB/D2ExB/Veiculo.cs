using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2ExB
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

        public void SetMatricula(string matricula)
        {
            _matricula = matricula;
        }

        public string GetMatricula()
        {
            return _matricula;
        }

        public void SetAno(int ano)
        {
            _ano = ano;
        }

        public int GetAno()
        {
            return _ano;
        }

        public void SetProprietario(Proprietario proprietario)
        {
            _proprietario = proprietario;
        }

        public Proprietario GetProprietario()
        {
            return _proprietario;
        }


        public virtual string ExibirDados()
        {
            return $"Matrícula: {_matricula}, Ano: {_ano}, Proprietário: {_proprietario.ExibirDados()}";
        }
    }
}
