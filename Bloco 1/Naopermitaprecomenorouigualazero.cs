class Produto
{
    public string Nome { get; set; }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Preço deve ser maior que zero.");
            preco = value;
        }
    }
}