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
    public class Configuracao
    {
       
        public readonly string VersaoSistema;

        public Configuracao(string versao)
        {
            VersaoSistema = versao;
        }

       
        public override string ToString()
        {
            return $"Configuração do Sistema - Versão: {VersaoSistema}";
        }
    }
}