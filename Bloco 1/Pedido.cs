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
    public class Pedido
    {
        
        public Guid Id { get; private set; } = Guid.NewGuid();

        public decimal ValorBase { get; set; }
        public decimal Desconto { get; set; }

            
        public decimal ValorTotal => ValorBase - Desconto;

        public decimal PrecoUnitario { get; internal set; }
        public int Quantidade { get; internal set; }
    }
}