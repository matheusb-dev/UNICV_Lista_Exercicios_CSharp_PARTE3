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
   
    public record Cliente(int V, string Nome, string Email);

    public class RelatorioCliente
    {
       
        public string FormatarParaExibicao(Cliente cliente)
        {
            return $"CLIENTE: {cliente.Nome.ToUpper()} | CONTATO: {cliente.Email.ToLower()}";
        }
    }
}