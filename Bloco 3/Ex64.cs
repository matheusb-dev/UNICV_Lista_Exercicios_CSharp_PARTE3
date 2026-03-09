class Circulo : Forma
{
    public double Raio;

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}