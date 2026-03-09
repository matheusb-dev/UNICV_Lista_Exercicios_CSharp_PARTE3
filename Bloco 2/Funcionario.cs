/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023
  
   NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

   Exercicios 46, 49, 50, 51: Funcionario.cs
 
 */
class Funcionario : Pessoa
{
    protected double salario;

    public Funcionario(string nome, double salario) : base(nome)
    {
        this.salario = salario;
    }

    public virtual void Trabalhar()
    {
        Console.WriteLine("Funcionário trabalhando...");
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Salário: {salario}");
    }
}