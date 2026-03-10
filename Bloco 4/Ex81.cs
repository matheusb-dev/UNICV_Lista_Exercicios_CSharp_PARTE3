using System;

namespace EXSC_
{
    internal class Ex81
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