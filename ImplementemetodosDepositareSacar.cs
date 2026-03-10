class ContaBancaria
{
    private double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        saldo -= valor;
    }
}
