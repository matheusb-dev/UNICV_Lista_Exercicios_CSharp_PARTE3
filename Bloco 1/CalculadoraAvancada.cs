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
    public class CalculadoraAvancada
    {
        
        public string Identificador { get; init; }

       
        public int Quadrado(int n) => n * n;

        
        public void LogResultado(int valor, string mensagem = "Resultado calculado")
        {
            Console.WriteLine($"{mensagem}: {valor}");
        }
    }
}