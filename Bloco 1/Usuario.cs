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
    public class Usuario
    {
        public static int ContadorInstancias { get; private set; } = 0;
        public string Nome { get; set; }

        
        public static int TotalUsuarios => ContadorInstancias;

        public Usuario(string nome)
        {
            Nome = nome;
            ContadorInstancias++;
        }
    }
}