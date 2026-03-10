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
    public class Carro
    {
        public string Modelo { get; set; }
        public int Velocidade { get; private set; }
        public string Placa { get; internal set; }

        public Carro(string modelo, string v)
        {
            this.Modelo = modelo;
            this.Velocidade = 0;
        }

    
        public void Acelerar(int incremento)
        {
            Velocidade += incremento;
            Console.WriteLine($"{Modelo} acelerou para {Velocidade} km/h.");
        }
    }
}