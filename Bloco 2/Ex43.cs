sealed class Moto : Veiculo
{
}class Carro : Veiculo
{
    public sealed override double CalcularConsumo(double distancia, double combustivel)
    {
        return distancia / combustivel;
    }
}