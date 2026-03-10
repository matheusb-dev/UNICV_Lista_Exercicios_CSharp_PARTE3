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
using System;

namespace bloco4
{
   
    public class Administrador : IAutenticavel
    {
        public bool Autenticar(string senha)
        {
            
            return senha == "Admin@123";
        }
    }

    
    public class Cliente : IAutenticavel
    {
        public bool Autenticar(string senha)
        {
            
            return senha == "1234";
        }
    }
}