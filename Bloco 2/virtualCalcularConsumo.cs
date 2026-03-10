class Veiculo
{
    public virtual double CalcularConsumo(double distancia, double combustivel)
    {
        return distancia / combustivel;
    }
}