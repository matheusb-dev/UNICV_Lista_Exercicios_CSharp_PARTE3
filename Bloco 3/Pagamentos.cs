/**NOME: Gabriel de Souza Mendes
   RA: 162874-2023
  
   NOME: Matheus Bezerra Domingos
   RA: 166479-2024
   
   NOME: Otávio Augusto Zangelmi Costa
   RA: 159752-2023

   NOME: Luiz Eduardo Marques da Silva 
   RA:168685-2024

   Exercicios 84–90: Pagamenti.cs
 
 */
class Pagamento : IPagamento
{
    public double Valor { get; set; }

    public Pagamento(double valor)
    {
        Valor = valor;
    }

    public virtual bool Processar()
    {
        return true;
    }
}

class PagamentoPix : Pagamento, IRecibo
{
    public PagamentoPix(double valor) : base(valor) { }

    public override bool Processar()
    {
        Console.WriteLine("Pagamento via PIX");
        return true;
    }

    public void GerarRecibo()
    {
        Console.WriteLine("Recibo PIX gerado");
    }
}

class PagamentoCartao : Pagamento, IRecibo
{
    public PagamentoCartao(double valor) : base(valor) { }

    public override bool Processar()
    {
        Console.WriteLine("Pagamento via Cartão");
        return true;
    }

    public void GerarRecibo()
    {
        Console.WriteLine("Recibo Cartão gerado");
    }
}