using System;

/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023

NOME: Matheus Bezerra Domingos
   RA: 166479-2024

NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024
*/
namespace bloco1
{
    public class Funcionario
    {
       
        private string _nome;
        private decimal _salario;

        public string Nome
        {
            get => _nome;
            set => _nome = string.IsNullOrWhiteSpace(value) ? "Anônimo" : value;
        }

        public decimal Salario
        {
            get => _salario;
            private set => _salario = value < 0 ? 0 : value;
        }

        public Funcionario(string nome, decimal salarioInicial)
        {
            Nome = nome;
            Salario = salarioInicial;
        }

        // 29. Crie classe com método que retorna string formatada
        public string ObterDadosFormatados()
        {
            return string.Format("Funcionario: {0} | Salário: {1:C}", Nome, Salario);
        }

        // 20. Sobrescreva ToString()
        public override string ToString()
        {
            return $"[ID Funcionario: {Nome}]";
        }
    }
}