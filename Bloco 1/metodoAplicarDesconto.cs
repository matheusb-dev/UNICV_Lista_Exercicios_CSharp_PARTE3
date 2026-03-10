class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public void AplicarDesconto(double percentual)
    {
        Preco -= Preco * (percentual / 100);
    }
}