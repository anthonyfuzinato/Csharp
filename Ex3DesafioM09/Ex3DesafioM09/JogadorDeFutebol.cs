using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3DesafioM09
{
    internal class JogadorDeFutebol
    {
        private string nome;
        private string posicao;
        private DateTime dataNascimento;
        private string nacionalidade;
        private double altura; // em cm
        private double peso;   // em kg

        public JogadorDeFutebol(string nomeJogador, string posicaoJogador, string dataNascimentoJogador, string nacionalidadeJogador, double alturaJogador, double pesoJogador)
        {
            nome = nomeJogador;
            posicao = posicaoJogador;
            dataNascimento = DateTime.ParseExact(dataNascimentoJogador, "dd/MM/yyyy", null);
            nacionalidade = nacionalidadeJogador;
            altura = alturaJogador;
            peso = pesoJogador;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nomeJogador)
        {
            nome = nomeJogador;
        }

        public string GetPosicao()
        {
            return posicao;
        }

        public void SetPosicao(string posicaoJogador)
        {
            posicao = posicaoJogador;
        }

        public string GetDataNascimento()
        {
            return dataNascimento.ToString("dd/MM/yyyy");
        }

        public void SetDataNascimento(string dataNascimentoJogador)
        {
            dataNascimento = DateTime.ParseExact(dataNascimentoJogador, "dd/MM/yyyy", null);
        }

        public string GetNacionalidade()
        {
            return nacionalidade;
        }

        public void SetNacionalidade(string nacionalidadeJogador)
        {
            nacionalidade = nacionalidadeJogador;
        }

        public double GetAltura()
        {
            return altura;
        }

        public void SetAltura(double alturaJogador)
        {
            altura = alturaJogador;
        }

        public double GetPeso()
        {
            return peso;
        }

        public void SetPeso(double pesoJogador)
        {
            peso = pesoJogador;
        }

        public int CalcularIdade()
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (DateTime.Now < dataNascimento.AddYears(idade))
                idade--;
            return idade;
        }

        public int TempoParaAposentadoria()
        {
            int idadeAtual = CalcularIdade();
            int idadeAposentadoria = 0;

            if (posicao.ToLower() == "defesa")
            {
                idadeAposentadoria = 40;
            }
            else if (posicao.ToLower() == "meio-campo")
            {
                idadeAposentadoria = 38;
            }
            else if (posicao.ToLower() == "atacante")
            {
                idadeAposentadoria = 35;
            }
            else
            {
                return -1;
            }

            return Math.Max(0, idadeAposentadoria - idadeAtual);
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {GetNome()}");
            Console.WriteLine($"Posição: {GetPosicao()}");
            Console.WriteLine($"Data de Nascimento: {GetDataNascimento()}");
            Console.WriteLine($"Nacionalidade: {GetNacionalidade()}");
            Console.WriteLine($"Altura: {GetAltura()} cm");
            Console.WriteLine($"Peso: {GetPeso()} kg");
            Console.WriteLine($"Idade: {CalcularIdade()} anos");
            Console.WriteLine($"Tempo para aposentadoria: {TempoParaAposentadoria()} anos");
        }
    }
}