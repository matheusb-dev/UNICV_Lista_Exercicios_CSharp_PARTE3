class ContaBancaria
{
    private double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor > saldo)
            Console.WriteLine("Saldo insuficiente.");
        else
            saldo -= valor;
    }
}