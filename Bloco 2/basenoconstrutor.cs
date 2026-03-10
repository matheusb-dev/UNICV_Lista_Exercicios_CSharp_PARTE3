class Veiculo
{
    public string Modelo;

    public Veiculo(string modelo)
    {
        Modelo = modelo;
    }
}

class Carro : Veiculo
{
    public Carro(string modelo) : base(modelo)
    {
    }
}