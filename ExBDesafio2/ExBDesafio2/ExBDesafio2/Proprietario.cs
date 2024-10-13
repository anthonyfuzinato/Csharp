using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExBDesafio2
{
    public class Proprietario
    {
        private string _nome;
        private string _numeroCartaConducao;
        private string _numeroIdentificacaoFiscal;

        public Proprietario(string nome, string numeroCartaConducao, string nif)
        {
            _nome = nome;
            _numeroCartaConducao = numeroCartaConducao;
            _numeroIdentificacaoFiscal = nif;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNumeroCartaConducao()
        {
            return _numeroCartaConducao;
        }

        public void SetNumeroCartaConducao(string numeroCartaConducao)
        {
            _numeroCartaConducao = numeroCartaConducao;
        }

        public string GetNumeroIdentificacaoFiscal()
        {
            return _numeroIdentificacaoFiscal;
        }

        public void SetNumeroIdentificacaoFiscal(string nif)
        {
            _numeroIdentificacaoFiscal = nif;
        }

        public string ObterDados()
        {
            return $"Proprietário: {_nome}, NIF: {_numeroIdentificacaoFiscal}, Carta de Condução: {_numeroCartaConducao}";
        }
    }
}
