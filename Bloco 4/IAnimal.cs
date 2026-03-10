using System;

namespace bloco4
{
    internal class IAnimal
    {
        interface IAnimal
        {
            void Andar();
        }

        interface ISom
        {
            void EmitirSom();
        }

        public class Cachorro : IAnimal, ISom
        {
            public void Andar()
            {
                Console.WriteLine("O cachorro está andando.");
            }

            public void EmitirSom()
            {
                Console.WriteLine("O cachorro está latindo.");
            }
        }
    }
}