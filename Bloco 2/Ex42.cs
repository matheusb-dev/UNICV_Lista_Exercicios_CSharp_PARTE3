class Carro : Veiculo
{
    public override double CalcularConsumo(double distancia, double combustivel)
    {
        return distancia / combustivel;
    }
}