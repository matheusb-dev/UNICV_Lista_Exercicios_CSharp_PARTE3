/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023
  
   NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

 
 */

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== ALUNO =====");

        Aluno aluno = new Aluno("Gabriel", 8);
        Console.WriteLine($"Aluno: {aluno.Nome}");
        Console.WriteLine($"Nota: {aluno.Nota}");
        Console.WriteLine($"Aprovado: {aluno.Aprovado()}");


        Console.WriteLine("\n===== HERANÇA =====");

        Gerente gerente = new Gerente("Carlos", 5000, "TI");
        gerente.ExibirDados();
        gerente.Trabalhar();


        Console.WriteLine("\n===== INTERFACES =====");

        List<IPagamento> pagamentos = new List<IPagamento>();

        pagamentos.Add(new PagamentoPix(200));
        pagamentos.Add(new PagamentoCartao(350));

        foreach (var p in pagamentos)
        {
            ProcessarPagamento(p);
        }
    }

    static void ProcessarPagamento(IPagamento pagamento)
    {
        if (pagamento.Processar())
        {
            Console.WriteLine($"Pagamento de {pagamento.Valor} realizado com sucesso.");
        }
    }
}