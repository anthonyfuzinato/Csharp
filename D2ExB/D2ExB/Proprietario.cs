using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2ExB
{
    public class Proprietario
    {
        private string _nome;
        private string _numeroCartaConducao;
        private string _numeroIdentificacaoFiscal;

        public Proprietario(string nome, string numeroCartaConducao, string numeroIdentificacaoFiscal)
        {
            _nome = nome;
            _numeroCartaConducao = numeroCartaConducao;
            _numeroIdentificacaoFiscal = numeroIdentificacaoFiscal;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNumeroCartaConducao(string numeroCartaConducao)
        {
            _numeroCartaConducao = numeroCartaConducao;
        }

        public string GetNumeroCartaConducao()
        {
            return _numeroCartaConducao;
        }

        public void SetNumeroIdentificacaoFiscal(string numeroIdentificacaoFiscal)
        {
            _numeroIdentificacaoFiscal = numeroIdentificacaoFiscal;
        }

        public string GetNumeroIdentificacaoFiscal()
        {
            return _numeroIdentificacaoFiscal;
        }

        // Função para transformar o nome no formato APELIDO, Nome
        public string TransformarNome()
        {
            string[] nomes = _nome.Split(' ');

            if (nomes.Length >= 2)
            {
                string primeiroNome = nomes[0];  
                string ultimoNome = nomes[nomes.Length - 1].ToUpper();  

                return $"{ultimoNome}, {primeiroNome}";
            }

            return _nome; 
        }

        public virtual string ExibirDados()
        {
            return $"Nome: {_nome}, Carta de Condução: {_numeroCartaConducao}, NIF: {_numeroIdentificacaoFiscal}";
        }
    }
}
