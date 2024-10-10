using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M9Desafio3Ex3
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cidade;

        public Pessoa(string nomePessoa, int idadePessoa, string cidadePessoa)
        {
            nome = nomePessoa;
            idade = idadePessoa;
            cidade = cidadePessoa;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, Cidade: {cidade}");
        }
    }
}