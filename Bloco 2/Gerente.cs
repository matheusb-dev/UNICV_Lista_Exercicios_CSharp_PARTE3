/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023
  
   NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

   Exercicios 47, 48, 52: Gerente.cs
 
 */
class Gerente : Funcionario
{
    private string departamento;

    public Gerente(string nome, double salario, string departamento)
        : base(nome, salario)
    {
        this.departamento = departamento;
    }

    public override void Trabalhar()
    {
        base.Trabalhar();
        Console.WriteLine("Gerente gerenciando equipe...");
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Departamento: {departamento}");
    }
}