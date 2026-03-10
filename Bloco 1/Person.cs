using System;
using System.Collections.Generic;

namespace bloco1
{
    internal class Person
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Pessoa(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }
        }
    }
}
