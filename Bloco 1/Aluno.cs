/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023
  
   NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

   Exercicios 12 - 16: Aluno.cs
 
 */

class Aluno
{
    public string Nome { get; }

    public double Nota { get; private set; }

    public readonly string Escola = "Escola Estadual";

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public bool Aprovado()
    {
        return Nota >= 7;
    }
}