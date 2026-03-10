using System;
using System.Collections.Generic;

namespace EXSC_
{
    internal class Ex65
    {
        public abstract class Forma
        {
            public abstract void Desenhar();
        }

        public class Circulo : Forma
        {
            public override void Desenhar()
            {
                Console.WriteLine("Desenhando círculo");
            }
        }

        public class Quadrado : Forma
        {
            public override void Desenhar()
            {
                Console.WriteLine("Desenhando quadrado");
            }
        }

        public void Testar()
        {
            List<Forma> formas = new List<Forma>();

            formas.Add(new Circulo());
            formas.Add(new Quadrado());

            foreach (Forma f in formas)
            {
                f.Desenhar();
            }
        }
    }
}