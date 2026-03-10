/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023

NOME: Matheus Bezerra Domingos
   RA: 166479-2024

NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024
*/

namespace bloco2
{
    public class Conta
    {
        public double Saldo { get; protected set; }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque na Conta Base.");
        }
    }
}