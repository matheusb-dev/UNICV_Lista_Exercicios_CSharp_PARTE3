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

namespace bloco4
{
    
    public class Documento : IImprimivel
    {
        public string Conteudo { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Documento: {Conteudo}");
        }
    }
}