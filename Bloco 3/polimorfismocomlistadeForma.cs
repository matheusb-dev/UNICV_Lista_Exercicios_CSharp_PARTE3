List<Forma> formas = new List<Forma>();

formas.Add(new Quadrado());
formas.Add(new Circulo());

foreach (var f in formas)
{
    Console.WriteLine(f.CalcularArea());
}